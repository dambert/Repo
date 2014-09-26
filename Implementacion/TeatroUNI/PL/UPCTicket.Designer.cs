namespace PL
{
    partial class UPCTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supervisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCredencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.butacasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supervisarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supervisarToolStripMenuItem
            // 
            this.supervisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.butacasToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.supervisarToolStripMenuItem.Name = "supervisarToolStripMenuItem";
            this.supervisarToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.supervisarToolStripMenuItem.Text = "Supervisar";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCredencialToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // administrarCredencialToolStripMenuItem
            // 
            this.administrarCredencialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.administrarCredencialToolStripMenuItem.Name = "administrarCredencialToolStripMenuItem";
            this.administrarCredencialToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.administrarCredencialToolStripMenuItem.Text = "Clientes";
            this.administrarCredencialToolStripMenuItem.Click += new System.EventHandler(this.administrarCredencialToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.agregarToolStripMenuItem.Text = "Agregar ";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajeroToolStripMenuItem,
            this.cajeroToolStripMenuItem1});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cajeroToolStripMenuItem.Text = "Agregar ";
            this.cajeroToolStripMenuItem.Click += new System.EventHandler(this.cajeroToolStripMenuItem_Click);
            // 
            // cajeroToolStripMenuItem1
            // 
            this.cajeroToolStripMenuItem1.Name = "cajeroToolStripMenuItem1";
            this.cajeroToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.cajeroToolStripMenuItem1.Text = "Listar";
            this.cajeroToolStripMenuItem1.Click += new System.EventHandler(this.cajeroToolStripMenuItem1_Click);
            // 
            // butacasToolStripMenuItem
            // 
            this.butacasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.butacasToolStripMenuItem.Name = "butacasToolStripMenuItem";
            this.butacasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.butacasToolStripMenuItem.Text = "Butacas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // UPCTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 517);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UPCTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPC-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UPCTicket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supervisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCredencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butacasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}