namespace PL.Ventas
{
    partial class Vender
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
            this.labelVenta = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPersonal = new System.Windows.Forms.GroupBox();
            this.textBoxApellidoPersonal = new System.Windows.Forms.TextBox();
            this.textBoxNombrePersonal = new System.Windows.Forms.TextBox();
            this.textBoxIDPersonal = new System.Windows.Forms.TextBox();
            this.labelApellidoPer = new System.Windows.Forms.Label();
            this.labelNombrePer = new System.Windows.Forms.Label();
            this.IDDP = new System.Windows.Forms.Label();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.textBoxRUCCLiente = new System.Windows.Forms.TextBox();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.labelRUCCliente = new System.Windows.Forms.Label();
            this.labelApellidoCliente = new System.Windows.Forms.Label();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.groupBoxDatoTicket = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxPrecioDeventa = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionTicket = new System.Windows.Forms.TextBox();
            this.textBoxIDTicket = new System.Windows.Forms.TextBox();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.labelDescripcionTicket = new System.Windows.Forms.Label();
            this.labelIDTicket = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxDatosPersonal.SuspendLayout();
            this.groupBoxDatosCliente.SuspendLayout();
            this.groupBoxDatoTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVenta
            // 
            this.labelVenta.AutoSize = true;
            this.labelVenta.Location = new System.Drawing.Point(147, 43);
            this.labelVenta.Name = "labelVenta";
            this.labelVenta.Size = new System.Drawing.Size(91, 13);
            this.labelVenta.TabIndex = 1;
            this.labelVenta.Text = "Venta de TICKET";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(558, 23);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Número";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(664, 23);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(763, 23);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(30, 13);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "Hora";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(541, 43);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(67, 20);
            this.textBoxNumero.TabIndex = 5;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(632, 43);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(91, 20);
            this.textBoxFecha.TabIndex = 6;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(739, 43);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(91, 20);
            this.textBoxHora.TabIndex = 7;
            // 
            // groupBoxDatosPersonal
            // 
            this.groupBoxDatosPersonal.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxDatosPersonal.Controls.Add(this.textBoxApellidoPersonal);
            this.groupBoxDatosPersonal.Controls.Add(this.textBoxNombrePersonal);
            this.groupBoxDatosPersonal.Controls.Add(this.textBoxIDPersonal);
            this.groupBoxDatosPersonal.Controls.Add(this.labelApellidoPer);
            this.groupBoxDatosPersonal.Controls.Add(this.labelNombrePer);
            this.groupBoxDatosPersonal.Controls.Add(this.IDDP);
            this.groupBoxDatosPersonal.Location = new System.Drawing.Point(24, 126);
            this.groupBoxDatosPersonal.Name = "groupBoxDatosPersonal";
            this.groupBoxDatosPersonal.Size = new System.Drawing.Size(402, 79);
            this.groupBoxDatosPersonal.TabIndex = 8;
            this.groupBoxDatosPersonal.TabStop = false;
            this.groupBoxDatosPersonal.Text = "Datos Personal";
            // 
            // textBoxApellidoPersonal
            // 
            this.textBoxApellidoPersonal.Location = new System.Drawing.Point(235, 42);
            this.textBoxApellidoPersonal.Name = "textBoxApellidoPersonal";
            this.textBoxApellidoPersonal.Size = new System.Drawing.Size(136, 20);
            this.textBoxApellidoPersonal.TabIndex = 12;
            // 
            // textBoxNombrePersonal
            // 
            this.textBoxNombrePersonal.Location = new System.Drawing.Point(84, 42);
            this.textBoxNombrePersonal.Name = "textBoxNombrePersonal";
            this.textBoxNombrePersonal.Size = new System.Drawing.Size(136, 20);
            this.textBoxNombrePersonal.TabIndex = 9;
            // 
            // textBoxIDPersonal
            // 
            this.textBoxIDPersonal.Location = new System.Drawing.Point(27, 42);
            this.textBoxIDPersonal.Name = "textBoxIDPersonal";
            this.textBoxIDPersonal.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDPersonal.TabIndex = 9;
            // 
            // labelApellidoPer
            // 
            this.labelApellidoPer.AutoSize = true;
            this.labelApellidoPer.Location = new System.Drawing.Point(232, 20);
            this.labelApellidoPer.Name = "labelApellidoPer";
            this.labelApellidoPer.Size = new System.Drawing.Size(49, 13);
            this.labelApellidoPer.TabIndex = 11;
            this.labelApellidoPer.Text = "Apellidos";
            this.labelApellidoPer.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelNombrePer
            // 
            this.labelNombrePer.AutoSize = true;
            this.labelNombrePer.Location = new System.Drawing.Point(81, 20);
            this.labelNombrePer.Name = "labelNombrePer";
            this.labelNombrePer.Size = new System.Drawing.Size(49, 13);
            this.labelNombrePer.TabIndex = 10;
            this.labelNombrePer.Text = "Nombres";
            // 
            // IDDP
            // 
            this.IDDP.AutoSize = true;
            this.IDDP.Location = new System.Drawing.Point(24, 20);
            this.IDDP.Name = "IDDP";
            this.IDDP.Size = new System.Drawing.Size(18, 13);
            this.IDDP.TabIndex = 9;
            this.IDDP.Text = "ID";
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxDatosCliente.Controls.Add(this.textBoxRUCCLiente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxApellidoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxIDCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelRUCCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelApellidoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelIDCliente);
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(437, 126);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(393, 79);
            this.groupBoxDatosCliente.TabIndex = 13;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos Cliente";
            this.groupBoxDatosCliente.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxRUCCLiente
            // 
            this.textBoxRUCCLiente.Location = new System.Drawing.Point(235, 42);
            this.textBoxRUCCLiente.Name = "textBoxRUCCLiente";
            this.textBoxRUCCLiente.Size = new System.Drawing.Size(152, 20);
            this.textBoxRUCCLiente.TabIndex = 12;
            // 
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(84, 42);
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(136, 20);
            this.textBoxApellidoCliente.TabIndex = 9;
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(27, 42);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDCliente.TabIndex = 9;
            // 
            // labelRUCCliente
            // 
            this.labelRUCCliente.AutoSize = true;
            this.labelRUCCliente.Location = new System.Drawing.Point(232, 20);
            this.labelRUCCliente.Name = "labelRUCCliente";
            this.labelRUCCliente.Size = new System.Drawing.Size(30, 13);
            this.labelRUCCliente.TabIndex = 11;
            this.labelRUCCliente.Text = "RUC";
            // 
            // labelApellidoCliente
            // 
            this.labelApellidoCliente.AutoSize = true;
            this.labelApellidoCliente.Location = new System.Drawing.Point(81, 20);
            this.labelApellidoCliente.Name = "labelApellidoCliente";
            this.labelApellidoCliente.Size = new System.Drawing.Size(44, 13);
            this.labelApellidoCliente.TabIndex = 10;
            this.labelApellidoCliente.Text = "Apellido";
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Location = new System.Drawing.Point(24, 20);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.Size = new System.Drawing.Size(18, 13);
            this.labelIDCliente.TabIndex = 9;
            this.labelIDCliente.Text = "ID";
            // 
            // groupBoxDatoTicket
            // 
            this.groupBoxDatoTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxDatoTicket.Controls.Add(this.textBoxTotal);
            this.groupBoxDatoTicket.Controls.Add(this.textBoxCantidad);
            this.groupBoxDatoTicket.Controls.Add(this.textBoxStock);
            this.groupBoxDatoTicket.Controls.Add(this.labelTotal);
            this.groupBoxDatoTicket.Controls.Add(this.labelCantidad);
            this.groupBoxDatoTicket.Controls.Add(this.labelStock);
            this.groupBoxDatoTicket.Controls.Add(this.textBoxPrecioDeventa);
            this.groupBoxDatoTicket.Controls.Add(this.textBoxDescripcionTicket);
            this.groupBoxDatoTicket.Controls.Add(this.textBoxIDTicket);
            this.groupBoxDatoTicket.Controls.Add(this.labelPrecioVenta);
            this.groupBoxDatoTicket.Controls.Add(this.labelDescripcionTicket);
            this.groupBoxDatoTicket.Controls.Add(this.labelIDTicket);
            this.groupBoxDatoTicket.Location = new System.Drawing.Point(24, 211);
            this.groupBoxDatoTicket.Name = "groupBoxDatoTicket";
            this.groupBoxDatoTicket.Size = new System.Drawing.Size(617, 79);
            this.groupBoxDatoTicket.TabIndex = 14;
            this.groupBoxDatoTicket.TabStop = false;
            this.groupBoxDatoTicket.Text = "Datos de Ticket";
            this.groupBoxDatoTicket.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(476, 42);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(108, 20);
            this.textBoxTotal.TabIndex = 18;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(417, 42);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(47, 20);
            this.textBoxCantidad.TabIndex = 17;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(353, 42);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(52, 20);
            this.textBoxStock.TabIndex = 16;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(473, 20);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Total";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(417, 20);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 14;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(354, 20);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 13;
            this.labelStock.Text = "Stock";
            // 
            // textBoxPrecioDeventa
            // 
            this.textBoxPrecioDeventa.Location = new System.Drawing.Point(247, 42);
            this.textBoxPrecioDeventa.Name = "textBoxPrecioDeventa";
            this.textBoxPrecioDeventa.Size = new System.Drawing.Size(96, 20);
            this.textBoxPrecioDeventa.TabIndex = 12;
            // 
            // textBoxDescripcionTicket
            // 
            this.textBoxDescripcionTicket.Location = new System.Drawing.Point(84, 42);
            this.textBoxDescripcionTicket.Name = "textBoxDescripcionTicket";
            this.textBoxDescripcionTicket.Size = new System.Drawing.Size(145, 20);
            this.textBoxDescripcionTicket.TabIndex = 9;
            // 
            // textBoxIDTicket
            // 
            this.textBoxIDTicket.Location = new System.Drawing.Point(27, 42);
            this.textBoxIDTicket.Name = "textBoxIDTicket";
            this.textBoxIDTicket.Size = new System.Drawing.Size(38, 20);
            this.textBoxIDTicket.TabIndex = 9;
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(244, 20);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(83, 13);
            this.labelPrecioVenta.TabIndex = 11;
            this.labelPrecioVenta.Text = "Precio de Venta";
            // 
            // labelDescripcionTicket
            // 
            this.labelDescripcionTicket.AutoSize = true;
            this.labelDescripcionTicket.Location = new System.Drawing.Point(81, 20);
            this.labelDescripcionTicket.Name = "labelDescripcionTicket";
            this.labelDescripcionTicket.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionTicket.TabIndex = 10;
            this.labelDescripcionTicket.Text = "Descripción";
            // 
            // labelIDTicket
            // 
            this.labelIDTicket.AutoSize = true;
            this.labelIDTicket.Location = new System.Drawing.Point(24, 20);
            this.labelIDTicket.Name = "labelIDTicket";
            this.labelIDTicket.Size = new System.Drawing.Size(18, 13);
            this.labelIDTicket.TabIndex = 9;
            this.labelIDTicket.Text = "ID";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminar.Location = new System.Drawing.Point(742, 211);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(88, 79);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuardar.Location = new System.Drawing.Point(325, 452);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(88, 79);
            this.buttonGuardar.TabIndex = 17;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelar.Location = new System.Drawing.Point(444, 452);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 79);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregar.Location = new System.Drawing.Point(648, 211);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 79);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseMnemonic = false;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PL.Properties.Resources.ticket;
            this.pictureBox2.Location = new System.Drawing.Point(24, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Vender
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(867, 535);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBoxDatoTicket);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Controls.Add(this.groupBoxDatosPersonal);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelVenta);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Vender";
            this.Load += new System.EventHandler(this.Vender_Load);
            this.groupBoxDatosPersonal.ResumeLayout(false);
            this.groupBoxDatosPersonal.PerformLayout();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.groupBoxDatoTicket.ResumeLayout(false);
            this.groupBoxDatoTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelVenta;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonal;
        private System.Windows.Forms.TextBox textBoxApellidoPersonal;
        private System.Windows.Forms.TextBox textBoxNombrePersonal;
        private System.Windows.Forms.TextBox textBoxIDPersonal;
        private System.Windows.Forms.Label labelApellidoPer;
        private System.Windows.Forms.Label labelNombrePer;
        private System.Windows.Forms.Label IDDP;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.TextBox textBoxRUCCLiente;
        private System.Windows.Forms.TextBox textBoxApellidoCliente;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private System.Windows.Forms.Label labelRUCCliente;
        private System.Windows.Forms.Label labelApellidoCliente;
        private System.Windows.Forms.Label labelIDCliente;
        private System.Windows.Forms.GroupBox groupBoxDatoTicket;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxPrecioDeventa;
        private System.Windows.Forms.TextBox textBoxDescripcionTicket;
        private System.Windows.Forms.TextBox textBoxIDTicket;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.Label labelDescripcionTicket;
        private System.Windows.Forms.Label labelIDTicket;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}