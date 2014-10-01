namespace PL.Venta
{
    partial class VBuscar
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
            this.dgvActualizarCodigoVenta = new System.Windows.Forms.DataGridView();
            this.btnBuscarAc = new System.Windows.Forms.Button();
            this.txtCodigoDeVenta = new System.Windows.Forms.TextBox();
            this.labelCodigodeVenta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarCodigoVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActualizarCodigoVenta
            // 
            this.dgvActualizarCodigoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarCodigoVenta.Location = new System.Drawing.Point(46, 106);
            this.dgvActualizarCodigoVenta.Name = "dgvActualizarCodigoVenta";
            this.dgvActualizarCodigoVenta.Size = new System.Drawing.Size(727, 152);
            this.dgvActualizarCodigoVenta.TabIndex = 7;
            // 
            // btnBuscarAc
            // 
            this.btnBuscarAc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarAc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAc.Location = new System.Drawing.Point(543, 25);
            this.btnBuscarAc.Name = "btnBuscarAc";
            this.btnBuscarAc.Size = new System.Drawing.Size(75, 35);
            this.btnBuscarAc.TabIndex = 6;
            this.btnBuscarAc.Text = "Buscar";
            this.btnBuscarAc.UseVisualStyleBackColor = false;
            // 
            // txtCodigoDeVenta
            // 
            this.txtCodigoDeVenta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoDeVenta.Location = new System.Drawing.Point(153, 36);
            this.txtCodigoDeVenta.Name = "txtCodigoDeVenta";
            this.txtCodigoDeVenta.Size = new System.Drawing.Size(313, 20);
            this.txtCodigoDeVenta.TabIndex = 5;
            this.txtCodigoDeVenta.Text = "                                C o d i g o              V e n t a";
            // 
            // labelCodigodeVenta
            // 
            this.labelCodigodeVenta.AutoSize = true;
            this.labelCodigodeVenta.Location = new System.Drawing.Point(6, 36);
            this.labelCodigodeVenta.Name = "labelCodigodeVenta";
            this.labelCodigodeVenta.Size = new System.Drawing.Size(92, 13);
            this.labelCodigodeVenta.TabIndex = 4;
            this.labelCodigodeVenta.Text = "Codigo de Venta :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(473, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 79);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrar.Location = new System.Drawing.Point(280, 345);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 79);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCodigodeVenta);
            this.groupBox1.Controls.Add(this.txtCodigoDeVenta);
            this.groupBox1.Controls.Add(this.btnBuscarAc);
            this.groupBox1.Location = new System.Drawing.Point(46, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar Venta";
            // 
            // VBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvActualizarCodigoVenta);
            this.Name = "VBuscar";
            this.Text = "VBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarCodigoVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActualizarCodigoVenta;
        private System.Windows.Forms.Button btnBuscarAc;
        private System.Windows.Forms.TextBox txtCodigoDeVenta;
        private System.Windows.Forms.Label labelCodigodeVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}