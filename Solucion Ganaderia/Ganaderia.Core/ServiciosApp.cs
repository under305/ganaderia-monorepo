using System.IO;
using Ganaderia.Core.Datos;
using Ganaderia.Core.Exportacion;
using Ganaderia.Core.Servicios;

namespace Ganaderia.Core
{
    /// <summary>
    /// Punto único para crear todos los servicios. <c>Program.cs</c> llama a
    /// <see cref="Iniciar"/> una vez y pasa este objeto a las vistas.
    /// Al agregar un servicio nuevo, créalo aquí.
    /// </summary>
    public class ServiciosApp
    {
        public RanchoService Ranchos { get; }
        public ExportadorTablet Exportador { get; }

        private ServiciosApp(ConexionSqlite db)
        {
            Ranchos = new RanchoService(new RanchoRepository(db));
            Exportador = new ExportadorTablet(db);
        }

        /// <summary>Crea la carpeta y la base si no existen y aplica las migraciones pendientes.</summary>
        public static ServiciosApp Iniciar(string rutaBaseDatos)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(rutaBaseDatos));
            var db = new ConexionSqlite(rutaBaseDatos);
            Migraciones.Aplicar(db);
            return new ServiciosApp(db);
        }
    }
}
