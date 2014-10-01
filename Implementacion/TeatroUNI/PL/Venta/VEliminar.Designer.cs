namespace PL.Venta
{
    partial class VEliminar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblVentaID = new System.Windows.Forms.Label();
            this.lblMostrarEventoSeleccionado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCodigodeVenta = new System.Windows.Forms.Label();
            this.txtCodigoDeVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarAc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblVentaID
            // 
            this.lblVentaID.AutoSize = true;
            this.lblVentaID.Location = new System.Drawing.Point(18, 283);
            this.lblVentaID.Name = "lblVentaID";
            this.lblVentaID.Size = new System.Drawing.Size(112, 13);
            this.lblVentaID.TabIndex = 1;
            this.lblVentaID.Text = "Evento Seleccionado:";
            // 
            // lblMostrarEventoSeleccionado
            // 
            this.lblMostrarEventoSeleccionado.AutoSize = true;
            this.lblMostrarEventoSeleccionado.Location = new System.Drawing.Point(136, 283);
            this.lblMostrarEventoSeleccionado.Name = "lblMostrarEventoSeleccionado";
            this.lblMostrarEventoSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarEventoSeleccionado.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(446, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 79);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(320, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 79);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCodigodeVenta);
            this.groupBox1.Controls.Add(this.txtCodigoDeVenta);
            this.groupBox1.Controls.Add(this.btnBuscarAc);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 49);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // labelCodigodeVenta
            // 
            this.labelCodigodeVenta.AutoSize = true;
            this.labelCodigodeVenta.Location = new System.Drawing.Point(6, 23);
            this.labelCodigodeVenta.Name = "labelCodigodeVenta";
            this.labelCodigodeVenta.Size = new System.Drawing.Size(92, 13);
            this.labelCodigodeVenta.TabIndex = 4;
            this.labelCodigodeVenta.Text = "Codigo de Venta :";
            // 
            // txtCodigoDeVenta
            // 
            this.txtCodigoDeVenta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoDeVenta.Location = new System.Drawing.Point(104, 23);
            this.txtCodigoDeVenta.Name = "txtCodigoDeVenta";
            this.txtCodigoDeVenta.Size = new System.Drawing.Size(313, 20);
            this.txtCodigoDeVenta.TabIndex = 5;
            this.txtCodigoDeVenta.Text = "                                C o d i g o              V e n t a";
            // 
            // btnBuscarAc
            // 
            this.btnBuscarAc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAc.Location = new System.Drawing.Point(423, 12);
            this.btnBuscarAc.Name = "btnBuscarAc";
            this.btnBuscarAc.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarAc.TabIndex = 6;
            this.btnBuscarAc.Text = "Buscar";
            this.btnBuscarAc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Eliminar Venta";
            // 
            // VEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblMostrarEventoSeleccionado);
            this.Controls.Add(this.lblVentaID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VEliminar";
            this.Text = "VEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVentaID;
        private System.Windows.Forms.Label lblMostrarEventoSeleccionado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCodigodeVenta;
        private System.Windows.Forms.TextBox txtCodigoDeVenta;
        private System.Windows.Forms.Button btnBuscarAc;
        private System.Windows.Forms.Label label1;
    }
}