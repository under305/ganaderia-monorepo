namespace Solucion_Ganaderia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainView1 = new Solucion_Ganaderia.MainView();
            this.SuspendLayout();
            //
            // mainView1
            //
            this.mainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView1.Location = new System.Drawing.Point(0, 0);
            this.mainView1.Name = "mainView1";
            this.mainView1.Size = new System.Drawing.Size(1848, 975);
            this.mainView1.TabIndex = 0;
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1848, 975);
            this.Controls.Add(this.mainView1);
            this.Name = "Form1";
            this.Text = "SIRGAN — Rancho Los Álamos";
            this.ResumeLayout(false);

        }

        #endregion

        private Solucion_Ganaderia.MainView mainView1;
    }
}

