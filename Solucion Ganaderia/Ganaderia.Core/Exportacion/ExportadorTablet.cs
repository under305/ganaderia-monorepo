using System;
using System.Data.SQLite;
using System.IO;
using Ganaderia.Core.Comun;
using Ganaderia.Core.Datos;

namespace Ganaderia.Core.Exportacion
{
    /// <summary>
    /// Genera el archivo .db que se pasa a la tablet. Es una copia compacta y
    /// consistente de la base (<c>VACUUM INTO</c>), con la misma <c>user_version</c>.
    /// </summary>
    public class ExportadorTablet
    {
        private readonly ConexionSqlite _db;

        public ExportadorTablet(ConexionSqlite db)
        {
            _db = db;
        }

        /// <summary>Si <paramref name="rutaDestino"/> ya existe, se reemplaza.</summary>
        public Resultado Exportar(string rutaDestino)
        {
            if (string.IsNullOrWhiteSpace(rutaDestino))
                return Resultado.Error("Elige dónde guardar el archivo.");
            if (string.Equals(Path.GetFullPath(rutaDestino), Path.GetFullPath(_db.RutaArchivo), StringComparison.OrdinalIgnoreCase))
                return Resultado.Error("No puedes exportar sobre la base de datos principal.");

            try
            {
                // VACUUM INTO falla si el destino ya existe.
                if (File.Exists(rutaDestino))
                    File.Delete(rutaDestino);

                using (var conexion = _db.Abrir())
                using (var cmd = new SQLiteCommand("VACUUM INTO @destino;", conexion))
                {
                    cmd.Parameters.AddWithValue("@destino", rutaDestino);
                    cmd.ExecuteNonQuery();
                }
                return Resultado.Ok();
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is SQLiteException)
            {
                return Resultado.Error($"No se pudo exportar: {ex.Message}");
            }
        }
    }
}
