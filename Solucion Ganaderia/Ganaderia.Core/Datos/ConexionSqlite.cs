using System.Data.SQLite;

namespace Ganaderia.Core.Datos
{
    /// <summary>
    /// Sabe dónde está el archivo de la base y abre conexiones listas para usar.
    /// Cada operación abre su propia conexión y la cierra con <c>using</c>.
    /// </summary>
    public class ConexionSqlite
    {
        public string RutaArchivo { get; }

        private readonly string _cadena;

        public ConexionSqlite(string rutaArchivo)
        {
            RutaArchivo = rutaArchivo;
            _cadena = new SQLiteConnectionStringBuilder
            {
                DataSource = rutaArchivo,
                ForeignKeys = true,
            }.ToString();
        }

        public SQLiteConnection Abrir()
        {
            var conexion = new SQLiteConnection(_cadena);
            conexion.Open();
            return conexion;
        }
    }
}
