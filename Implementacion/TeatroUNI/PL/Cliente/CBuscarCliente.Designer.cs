namespace PL.Butacas
{
    partial class CBuscarCliente
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
            this.labelBuscarCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerButaca = new System.Windows.Forms.Button();
            this.labelDnioNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuscarCliente
            // 
            this.labelBuscarCliente.AutoSize = true;
            this.labelBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarCliente.Location = new System.Drawing.Point(268, 9);
            this.labelBuscarCliente.Name = "labelBuscarCliente";
            this.labelBuscarCliente.Size = new System.Drawing.Size(145, 24);
            this.labelBuscarCliente.TabIndex = 26;
            this.labelBuscarCliente.Text = "Buscar Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelDnioNombre);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(36, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 62);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(458, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 29);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarTodos.Location = new System.Drawing.Point(36, 115);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(126, 31);
            this.btnListarTodos.TabIndex = 28;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 143);
            this.dataGridView1.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerButaca);
            this.groupBox2.Location = new System.Drawing.Point(272, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 83);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manejar Cliente";
            // 
            // btnVerButaca
            // 
            this.btnVerButaca.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerButaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerButaca.Location = new System.Drawing.Point(24, 33);
            this.btnVerButaca.Name = "btnVerButaca";
            this.btnVerButaca.Size = new System.Drawing.Size(126, 31);
            this.btnVerButaca.TabIndex = 27;
            this.btnVerButaca.Text = "Ver Butaca";
            this.btnVerButaca.UseVisualStyleBackColor = false;
            // 
            // labelDnioNombre
            // 
            this.labelDnioNombre.AutoSize = true;
            this.labelDnioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnioNombre.Location = new System.Drawing.Point(37, 27);
            this.labelDnioNombre.Name = "labelDnioNombre";
            this.labelDnioNombre.Size = new System.Drawing.Size(266, 16);
            this.labelDnioNombre.TabIndex = 10;
            this.labelDnioNombre.Text = "Ingrese el Dni o Nombre del Cliente : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // CBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBuscarCliente);
            this.Name = "CBuscarCliente";
            this.Text = "CBuscarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerButaca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDnioNombre;
    }
}