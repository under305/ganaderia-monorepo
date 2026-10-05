using System.Windows.Forms;
using Ganaderia.Core;

namespace Solucion_Ganaderia
{
    /// <summary>
    /// Ventana principal. Solo enruta: recibe la opción elegida en <see cref="MainView"/>
    /// y abre la pantalla correspondiente. La lógica vive en <see cref="ServiciosApp"/>.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly ServiciosApp _servicios;

        public Form1(ServiciosApp servicios)
        {
            InitializeComponent();
            _servicios = servicios;

            mainView1.MenuOptionActivated += MainView_MenuOptionActivated;
            mainView1.CloseRequested += (s, e) => ConfirmarSalida();
        }

        private void MainView_MenuOptionActivated(object sender, MainView.MenuOptionEventArgs e)
        {
            switch (e.Key)
            {
                case "2":
                    AbrirDialogo(new AgregarRanchoForm(_servicios.Ranchos));
                    break;

                case "J":
                    // MainView ya dispara CloseRequested para "Salir".
                    break;

                default:
                    MessageBox.Show(this, $"\"{e.Text}\" todavía no está disponible.", "SIRGAN",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void AbrirDialogo(Form dialogo)
        {
            using (dialogo)
            {
                dialogo.ShowDialog(this);
            }
            mainView1.Focus();
        }

        private void ConfirmarSalida()
        {
            var respuesta = MessageBox.Show(this, "¿Salir de SIRGAN?", "SIRGAN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
