namespace Solucion_Ganaderia
{
    partial class MainView
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

        #region Código generado por el Diseñador de componentes

        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrCursor;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblRanchoTitle;
        private System.Windows.Forms.Label lblLoteActivo;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Panel pnlHeaderDivider;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lblMenuBarTitle;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlFooterDivider;
        private System.Windows.Forms.Label lblFooterHints;
        private System.Windows.Forms.Label lblCursor;
        private System.Windows.Forms.Panel pnlMenuBody;
        private System.Windows.Forms.Panel pnlMenuLeft;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.Label lblItem6;
        private System.Windows.Forms.Label lblItem7;
        private System.Windows.Forms.Label lblItem8;
        private System.Windows.Forms.Label lblItem9;
        private System.Windows.Forms.Panel pnlMenuRight;
        private System.Windows.Forms.Label lblItemA;
        private System.Windows.Forms.Label lblItemB;
        private System.Windows.Forms.Label lblItemC;
        private System.Windows.Forms.Label lblItemD;
        private System.Windows.Forms.Label lblItemE;
        private System.Windows.Forms.Label lblItemF;
        private System.Windows.Forms.Label lblItemG;
        private System.Windows.Forms.Label lblItemH;
        private System.Windows.Forms.Label lblItemI;
        private System.Windows.Forms.Label lblItemJ;

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrCursor = new System.Windows.Forms.Timer(this.components);
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.pnlMenuBody = new System.Windows.Forms.Panel();
            this.pnlMenuRight = new System.Windows.Forms.Panel();
            this.lblItemA = new System.Windows.Forms.Label();
            this.lblItemB = new System.Windows.Forms.Label();
            this.lblItemC = new System.Windows.Forms.Label();
            this.lblItemD = new System.Windows.Forms.Label();
            this.lblItemE = new System.Windows.Forms.Label();
            this.lblItemF = new System.Windows.Forms.Label();
            this.lblItemG = new System.Windows.Forms.Label();
            this.lblItemH = new System.Windows.Forms.Label();
            this.lblItemI = new System.Windows.Forms.Label();
            this.lblItemJ = new System.Windows.Forms.Label();
            this.pnlMenuLeft = new System.Windows.Forms.Panel();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.lblItem6 = new System.Windows.Forms.Label();
            this.lblItem7 = new System.Windows.Forms.Label();
            this.lblItem8 = new System.Windows.Forms.Label();
            this.lblItem9 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterHints = new System.Windows.Forms.Label();
            this.lblCursor = new System.Windows.Forms.Label();
            this.pnlFooterDivider = new System.Windows.Forms.Panel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.btnModo = new System.Windows.Forms.Button();
            this.lblMenuBarTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblLoteActivo = new System.Windows.Forms.Label();
            this.lblRanchoTitle = new System.Windows.Forms.Label();
            this.pnlHeaderDivider = new System.Windows.Forms.Panel();
            this.pnlConsole.SuspendLayout();
            this.pnlMenuBody.SuspendLayout();
            this.pnlMenuRight.SuspendLayout();
            this.pnlMenuLeft.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMenuBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrCursor
            // 
            this.tmrCursor.Enabled = true;
            this.tmrCursor.Interval = 500;
            this.tmrCursor.Tick += new System.EventHandler(this.tmrCursor_Tick);
            // 
            // pnlConsole
            // 
            this.pnlConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsole.Controls.Add(this.pnlMenuBody);
            this.pnlConsole.Controls.Add(this.pnlFooter);
            this.pnlConsole.Controls.Add(this.pnlMenuBar);
            this.pnlConsole.Controls.Add(this.pnlHeader);
            this.pnlConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsole.Location = new System.Drawing.Point(16, 16);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(1528, 868);
            this.pnlConsole.TabIndex = 0;
            // 
            // pnlMenuBody
            // 
            this.pnlMenuBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlMenuBody.Controls.Add(this.pnlMenuRight);
            this.pnlMenuBody.Controls.Add(this.pnlMenuLeft);
            this.pnlMenuBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuBody.Location = new System.Drawing.Point(0, 144);
            this.pnlMenuBody.Name = "pnlMenuBody";
            this.pnlMenuBody.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
            this.pnlMenuBody.Size = new System.Drawing.Size(1526, 670);
            this.pnlMenuBody.TabIndex = 2;
            // 
            // pnlMenuRight
            // 
            this.pnlMenuRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlMenuRight.Controls.Add(this.lblItemA);
            this.pnlMenuRight.Controls.Add(this.lblItemB);
            this.pnlMenuRight.Controls.Add(this.lblItemC);
            this.pnlMenuRight.Controls.Add(this.lblItemD);
            this.pnlMenuRight.Controls.Add(this.lblItemE);
            this.pnlMenuRight.Controls.Add(this.lblItemF);
            this.pnlMenuRight.Controls.Add(this.lblItemG);
            this.pnlMenuRight.Controls.Add(this.lblItemH);
            this.pnlMenuRight.Controls.Add(this.lblItemI);
            this.pnlMenuRight.Controls.Add(this.lblItemJ);
            this.pnlMenuRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuRight.Location = new System.Drawing.Point(744, 10);
            this.pnlMenuRight.Name = "pnlMenuRight";
            this.pnlMenuRight.Size = new System.Drawing.Size(758, 650);
            this.pnlMenuRight.TabIndex = 1;
            // 
            // lblItemA
            // 
            this.lblItemA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemA.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemA.Location = new System.Drawing.Point(40, 8);
            this.lblItemA.Name = "lblItemA";
            this.lblItemA.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemA.Size = new System.Drawing.Size(680, 36);
            this.lblItemA.TabIndex = 0;
            this.lblItemA.Text = "A.  Ventas";
            this.lblItemA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemB
            // 
            this.lblItemB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemB.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemB.Location = new System.Drawing.Point(40, 52);
            this.lblItemB.Name = "lblItemB";
            this.lblItemB.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemB.Size = new System.Drawing.Size(680, 36);
            this.lblItemB.TabIndex = 1;
            this.lblItemB.Text = "B.  Compras";
            this.lblItemB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemC
            // 
            this.lblItemC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemC.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemC.Location = new System.Drawing.Point(40, 96);
            this.lblItemC.Name = "lblItemC";
            this.lblItemC.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemC.Size = new System.Drawing.Size(680, 36);
            this.lblItemC.TabIndex = 2;
            this.lblItemC.Text = "C.  Sanidad / vacunación";
            this.lblItemC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemD
            // 
            this.lblItemD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemD.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemD.Location = new System.Drawing.Point(40, 140);
            this.lblItemD.Name = "lblItemD";
            this.lblItemD.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemD.Size = new System.Drawing.Size(680, 36);
            this.lblItemD.TabIndex = 3;
            this.lblItemD.Text = "D.  Reproducción";
            this.lblItemD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemE
            // 
            this.lblItemE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemE.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemE.Location = new System.Drawing.Point(40, 184);
            this.lblItemE.Name = "lblItemE";
            this.lblItemE.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemE.Size = new System.Drawing.Size(680, 36);
            this.lblItemE.TabIndex = 4;
            this.lblItemE.Text = "E.  Alimentación";
            this.lblItemE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemF
            // 
            this.lblItemF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemF.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemF.Location = new System.Drawing.Point(40, 228);
            this.lblItemF.Name = "lblItemF";
            this.lblItemF.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemF.Size = new System.Drawing.Size(680, 36);
            this.lblItemF.TabIndex = 5;
            this.lblItemF.Text = "F.  Pesajes";
            this.lblItemF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemG
            // 
            this.lblItemG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemG.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemG.Location = new System.Drawing.Point(40, 272);
            this.lblItemG.Name = "lblItemG";
            this.lblItemG.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemG.Size = new System.Drawing.Size(680, 36);
            this.lblItemG.TabIndex = 6;
            this.lblItemG.Text = "G.  Usuarios y permisos";
            this.lblItemG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemH
            // 
            this.lblItemH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemH.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemH.Location = new System.Drawing.Point(40, 316);
            this.lblItemH.Name = "lblItemH";
            this.lblItemH.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemH.Size = new System.Drawing.Size(680, 36);
            this.lblItemH.TabIndex = 7;
            this.lblItemH.Text = "H.  Respaldo de datos";
            this.lblItemH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemI
            // 
            this.lblItemI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemI.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItemI.Location = new System.Drawing.Point(40, 360);
            this.lblItemI.Name = "lblItemI";
            this.lblItemI.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemI.Size = new System.Drawing.Size(680, 36);
            this.lblItemI.TabIndex = 8;
            this.lblItemI.Text = "I.  Ayuda";
            this.lblItemI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemJ
            // 
            this.lblItemJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItemJ.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItemJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(58)))), ((int)(((byte)(46)))));
            this.lblItemJ.Location = new System.Drawing.Point(40, 404);
            this.lblItemJ.Name = "lblItemJ";
            this.lblItemJ.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItemJ.Size = new System.Drawing.Size(680, 36);
            this.lblItemJ.TabIndex = 9;
            this.lblItemJ.Text = "J.  Salir";
            this.lblItemJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenuLeft
            // 
            this.pnlMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlMenuLeft.Controls.Add(this.lblItem1);
            this.pnlMenuLeft.Controls.Add(this.lblItem2);
            this.pnlMenuLeft.Controls.Add(this.lblItem3);
            this.pnlMenuLeft.Controls.Add(this.lblItem4);
            this.pnlMenuLeft.Controls.Add(this.lblItem5);
            this.pnlMenuLeft.Controls.Add(this.lblItem6);
            this.pnlMenuLeft.Controls.Add(this.lblItem7);
            this.pnlMenuLeft.Controls.Add(this.lblItem8);
            this.pnlMenuLeft.Controls.Add(this.lblItem9);
            this.pnlMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLeft.Location = new System.Drawing.Point(24, 10);
            this.pnlMenuLeft.Name = "pnlMenuLeft";
            this.pnlMenuLeft.Size = new System.Drawing.Size(720, 650);
            this.pnlMenuLeft.TabIndex = 0;
            // 
            // lblItem1
            // 
            this.lblItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(94)))), ((int)(((byte)(58)))));
            this.lblItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblItem1.ForeColor = System.Drawing.Color.White;
            this.lblItem1.Location = new System.Drawing.Point(0, 8);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem1.Size = new System.Drawing.Size(680, 36);
            this.lblItem1.TabIndex = 0;
            this.lblItem1.Text = "1.  Seleccionar rancho";
            this.lblItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItem1.Click += new System.EventHandler(this.lblItem1_Click);
            // 
            // lblItem2
            // 
            this.lblItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem2.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem2.Location = new System.Drawing.Point(0, 52);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem2.Size = new System.Drawing.Size(680, 36);
            this.lblItem2.TabIndex = 1;
            this.lblItem2.Text = "2.  Agregar rancho";
            this.lblItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem3
            // 
            this.lblItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem3.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem3.Location = new System.Drawing.Point(0, 96);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem3.Size = new System.Drawing.Size(680, 36);
            this.lblItem3.TabIndex = 2;
            this.lblItem3.Text = "3.  Agregar lote";
            this.lblItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem4
            // 
            this.lblItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem4.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem4.Location = new System.Drawing.Point(0, 140);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem4.Size = new System.Drawing.Size(680, 36);
            this.lblItem4.TabIndex = 3;
            this.lblItem4.Text = "4.  Agregar animal";
            this.lblItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem5
            // 
            this.lblItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem5.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem5.Location = new System.Drawing.Point(0, 184);
            this.lblItem5.Name = "lblItem5";
            this.lblItem5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem5.Size = new System.Drawing.Size(680, 36);
            this.lblItem5.TabIndex = 4;
            this.lblItem5.Text = "5.  Estatus de animal";
            this.lblItem5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem6
            // 
            this.lblItem6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem6.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem6.Location = new System.Drawing.Point(0, 228);
            this.lblItem6.Name = "lblItem6";
            this.lblItem6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem6.Size = new System.Drawing.Size(680, 36);
            this.lblItem6.TabIndex = 5;
            this.lblItem6.Text = "6.  Movimientos de hato";
            this.lblItem6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem7
            // 
            this.lblItem7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem7.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem7.Location = new System.Drawing.Point(0, 272);
            this.lblItem7.Name = "lblItem7";
            this.lblItem7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem7.Size = new System.Drawing.Size(680, 36);
            this.lblItem7.TabIndex = 6;
            this.lblItem7.Text = "7.  Reportes de producción";
            this.lblItem7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem8
            // 
            this.lblItem8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem8.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem8.Location = new System.Drawing.Point(0, 316);
            this.lblItem8.Name = "lblItem8";
            this.lblItem8.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem8.Size = new System.Drawing.Size(680, 36);
            this.lblItem8.TabIndex = 7;
            this.lblItem8.Text = "8.  Consultas rápidas";
            this.lblItem8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem9
            // 
            this.lblItem9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem9.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblItem9.Location = new System.Drawing.Point(0, 360);
            this.lblItem9.Name = "lblItem9";
            this.lblItem9.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItem9.Size = new System.Drawing.Size(680, 36);
            this.lblItem9.TabIndex = 8;
            this.lblItem9.Text = "9.  Configuración";
            this.lblItem9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlFooter.Controls.Add(this.lblFooterHints);
            this.pnlFooter.Controls.Add(this.lblCursor);
            this.pnlFooter.Controls.Add(this.pnlFooterDivider);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 814);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1526, 52);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooterHints
            // 
            this.lblFooterHints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooterHints.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lblFooterHints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(44)))));
            this.lblFooterHints.Location = new System.Drawing.Point(0, 2);
            this.lblFooterHints.Name = "lblFooterHints";
            this.lblFooterHints.Padding = new System.Windows.Forms.Padding(24, 0, 16, 0);
            this.lblFooterHints.Size = new System.Drawing.Size(1526, 50);
            this.lblFooterHints.TabIndex = 0;
            this.lblFooterHints.Text = "1-9 / A-J abrir opción    ↑↓ navegar lista    Enter confirmar    Esc cerrar";
            this.lblFooterHints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCursor
            // 
            this.lblCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCursor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblCursor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblCursor.Location = new System.Drawing.Point(1478, 14);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(24, 26);
            this.lblCursor.TabIndex = 1;
            this.lblCursor.Text = "█";
            this.lblCursor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooterDivider
            // 
            this.pnlFooterDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(38)))));
            this.pnlFooterDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooterDivider.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterDivider.Name = "pnlFooterDivider";
            this.pnlFooterDivider.Size = new System.Drawing.Size(1526, 2);
            this.pnlFooterDivider.TabIndex = 2;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlMenuBar.Controls.Add(this.btnModo);
            this.pnlMenuBar.Controls.Add(this.lblMenuBarTitle);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 92);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(1526, 52);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // btnModo
            // 
            this.btnModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.btnModo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(38)))));
            this.btnModo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModo.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(44)))));
            this.btnModo.Location = new System.Drawing.Point(1242, 9);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(260, 34);
            this.btnModo.TabIndex = 1;
            this.btnModo.Text = "Modo: Claro (clic para cambiar)";
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // lblMenuBarTitle
            // 
            this.lblMenuBarTitle.AutoSize = true;
            this.lblMenuBarTitle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblMenuBarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblMenuBarTitle.Location = new System.Drawing.Point(24, 15);
            this.lblMenuBarTitle.Name = "lblMenuBarTitle";
            this.lblMenuBarTitle.Size = new System.Drawing.Size(975, 36);
            this.lblMenuBarTitle.TabIndex = 0;
            this.lblMenuBarTitle.Text = "—[ MENÚ PRINCIPAL — SIRGAN ]————————————————————————————————";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.pnlHeader.Controls.Add(this.lblOperador);
            this.pnlHeader.Controls.Add(this.lblClock);
            this.pnlHeader.Controls.Add(this.lblLoteActivo);
            this.pnlHeader.Controls.Add(this.lblRanchoTitle);
            this.pnlHeader.Controls.Add(this.pnlHeaderDivider);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1526, 92);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblOperador
            // 
            this.lblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperador.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(44)))));
            this.lblOperador.Location = new System.Drawing.Point(1242, 52);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(260, 22);
            this.lblOperador.TabIndex = 3;
            this.lblOperador.Text = "Operador: J. PÉREZ";
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblClock.Location = new System.Drawing.Point(1342, 14);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(160, 26);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "0:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoteActivo
            // 
            this.lblLoteActivo.AutoSize = true;
            this.lblLoteActivo.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblLoteActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(98)))));
            this.lblLoteActivo.Location = new System.Drawing.Point(24, 52);
            this.lblLoteActivo.Name = "lblLoteActivo";
            this.lblLoteActivo.Size = new System.Drawing.Size(269, 32);
            this.lblLoteActivo.TabIndex = 1;
            this.lblLoteActivo.Text = "Lote activo: L-04";
            // 
            // lblRanchoTitle
            // 
            this.lblRanchoTitle.AutoSize = true;
            this.lblRanchoTitle.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblRanchoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblRanchoTitle.Location = new System.Drawing.Point(24, 14);
            this.lblRanchoTitle.Name = "lblRanchoTitle";
            this.lblRanchoTitle.Size = new System.Drawing.Size(398, 45);
            this.lblRanchoTitle.TabIndex = 0;
            this.lblRanchoTitle.Text = "RANCHO: LOS ÁLAMOS";
            // 
            // pnlHeaderDivider
            // 
            this.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(38)))));
            this.pnlHeaderDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlHeaderDivider.Name = "pnlHeaderDivider";
            this.pnlHeaderDivider.Size = new System.Drawing.Size(1526, 2);
            this.pnlHeaderDivider.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.pnlConsole);
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(1560, 900);
            this.pnlConsole.ResumeLayout(false);
            this.pnlMenuBody.ResumeLayout(false);
            this.pnlMenuRight.ResumeLayout(false);
            this.pnlMenuLeft.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
