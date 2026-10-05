using System;
using System.Windows.Forms;
using Ganaderia.Core.Servicios;

namespace Solucion_Ganaderia
{
    /// <summary>
    /// Ejemplo del patrón vista → servicio: la pantalla solo lee los campos,
    /// llama a <see cref="RanchoService.Agregar"/> y muestra el resultado.
    /// </summary>
    public partial class AgregarRanchoForm : Form
    {
        private readonly RanchoService _ranchos;

        public AgregarRanchoForm(RanchoService ranchos)
        {
            InitializeComponent();
            _ranchos = ranchos;

            txtNombre.MaxLength = RanchoService.LongitudMaximaNombre;
            txtUbicacion.MaxLength = RanchoService.LongitudMaximaUbicacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var resultado = _ranchos.Agregar(txtNombre.Text, txtUbicacion.Text);
            if (!resultado.Exito)
            {
                lblError.Text = resultado.Mensaje;
                txtNombre.Focus();
                return;
            }

            MessageBox.Show(this, $"Rancho \"{resultado.Valor.Nombre}\" guardado.", "SIRGAN",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
