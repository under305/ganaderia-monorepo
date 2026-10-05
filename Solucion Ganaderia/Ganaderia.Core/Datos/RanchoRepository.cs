using System.Collections.Generic;
using System.Data.SQLite;
using Ganaderia.Core.Comun;
using Ganaderia.Core.Modelos;

namespace Ganaderia.Core.Datos
{
    /// <summary>
    /// Solo SQL: leer y escribir ranchos. Las validaciones van en <c>RanchoService</c>.
    /// </summary>
    public class RanchoRepository
    {
        private readonly ConexionSqlite _db;

        public RanchoRepository(ConexionSqlite db)
        {
            _db = db;
        }

        public bool ExisteNombre(string nombre)
        {
            using (var conexion = _db.Abrir())
            using (var cmd = new SQLiteCommand("SELECT 1 FROM ranchos WHERE nombre_clave = @clave LIMIT 1;", conexion))
            {
                cmd.Parameters.AddWithValue("@clave", Texto.Clave(nombre));
                return cmd.ExecuteScalar() != null;
            }
        }

        public void Insertar(Rancho rancho)
        {
            using (var conexion = _db.Abrir())
            using (var cmd = new SQLiteCommand(
                @"INSERT INTO ranchos (id, nombre, nombre_clave, ubicacion, creado_en, actualizado_en)
                  VALUES (@id, @nombre, @clave, @ubicacion, @creado, @actualizado);", conexion))
            {
                cmd.Parameters.AddWithValue("@id", rancho.Id);
                cmd.Parameters.AddWithValue("@nombre", rancho.Nombre);
                cmd.Parameters.AddWithValue("@clave", Texto.Clave(rancho.Nombre));
                cmd.Parameters.AddWithValue("@ubicacion", FormatoSqlite.Texto(rancho.Ubicacion));
                cmd.Parameters.AddWithValue("@creado", FormatoSqlite.Fecha(rancho.CreadoEn));
                cmd.Parameters.AddWithValue("@actualizado", FormatoSqlite.Fecha(rancho.ActualizadoEn));
                cmd.ExecuteNonQuery();
            }
        }

        public List<Rancho> ObtenerTodos()
        {
            var ranchos = new List<Rancho>();
            using (var conexion = _db.Abrir())
            using (var cmd = new SQLiteCommand(
                "SELECT id, nombre, ubicacion, creado_en, actualizado_en FROM ranchos ORDER BY nombre;", conexion))
            using (var lector = cmd.ExecuteReader())
            {
                while (lector.Read())
                {
                    ranchos.Add(new Rancho
                    {
                        Id = (string)lector["id"],
                        Nombre = (string)lector["nombre"],
                        Ubicacion = FormatoSqlite.LeerTexto(lector["ubicacion"]),
                        CreadoEn = FormatoSqlite.LeerFecha(lector["creado_en"]),
                        ActualizadoEn = FormatoSqlite.LeerFecha(lector["actualizado_en"]),
                    });
                }
            }
            return ranchos;
        }
    }
}
