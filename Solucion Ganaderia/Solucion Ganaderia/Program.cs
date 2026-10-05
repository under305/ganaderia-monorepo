using System;
using System.IO;
using System.Windows.Forms;
using Ganaderia.Core;

namespace Solucion_Ganaderia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // %LOCALAPPDATA%\SIRGAN\ganaderia.db: siempre tiene permisos de escritura,
            // aunque el programa esté instalado en "Archivos de programa".
            string rutaBaseDatos = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "SIRGAN",
                "ganaderia.db");

            ServiciosApp servicios;
            try
            {
                servicios = ServiciosApp.Iniciar(rutaBaseDatos);
            }
            catch (Exception ex)
            {
                // Típico en una PC nueva: falta SQLite.Interop.dll (no se copió la carpeta x86\ completa).
                MessageBox.Show(
                    $"No se pudo abrir la base de datos:\n{rutaBaseDatos}\n\n{ex.Message}",
                    "SIRGAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1(servicios));
        }
    }
}
