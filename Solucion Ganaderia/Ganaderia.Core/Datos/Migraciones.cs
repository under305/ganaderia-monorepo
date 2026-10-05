using System;
using System.Data.SQLite;

namespace Ganaderia.Core.Datos
{
    /// <summary>
    /// Esquema versionado de la base. La versión se guarda en <c>PRAGMA user_version</c>
    /// y la tablet la revisa antes de abrir un exportable.
    ///
    /// Para cambiar el esquema: agrega un paso NUEVO al final de <see cref="Pasos"/>.
    /// Nunca edites un paso que ya se aplicó en alguna PC.
    ///
    /// Reglas de tipos (para que la tablet lea lo mismo):
    ///   - IDs: TEXT con UUID.
    ///   - Fechas: TEXT ISO-8601 en UTC (ver <see cref="FormatoSqlite"/>).
    ///   - Booleanos: INTEGER 0/1.
    /// </summary>
    public static class Migraciones
    {
        private static readonly string[] Pasos =
        {
            // Versión 1
            @"CREATE TABLE ranchos (
                  id             TEXT PRIMARY KEY NOT NULL,
                  nombre         TEXT NOT NULL,
                  nombre_clave   TEXT NOT NULL UNIQUE, -- Texto.Clave(nombre): evita duplicados por acentos/mayúsculas
                  ubicacion      TEXT,
                  creado_en      TEXT NOT NULL,
                  actualizado_en TEXT NOT NULL
              );",
        };

        public static int VersionActual => Pasos.Length;

        /// <summary>Aplica los pasos pendientes. Es seguro llamarlo en cada arranque.</summary>
        public static void Aplicar(ConexionSqlite db)
        {
            using (var conexion = db.Abrir())
            {
                int version = LeerVersion(conexion);
                if (version > VersionActual)
                {
                    throw new InvalidOperationException(
                        $"La base de datos es de una versión más nueva ({version}) que este programa ({VersionActual}). Actualiza SIRGAN.");
                }

                for (int i = version; i < Pasos.Length; i++)
                {
                    using (var tx = conexion.BeginTransaction())
                    {
                        Ejecutar(conexion, Pasos[i]);
                        Ejecutar(conexion, $"PRAGMA user_version = {i + 1};");
                        tx.Commit();
                    }
                }
            }
        }

        private static int LeerVersion(SQLiteConnection conexion)
        {
            using (var cmd = new SQLiteCommand("PRAGMA user_version;", conexion))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static void Ejecutar(SQLiteConnection conexion, string sql)
        {
            using (var cmd = new SQLiteCommand(sql, conexion))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
