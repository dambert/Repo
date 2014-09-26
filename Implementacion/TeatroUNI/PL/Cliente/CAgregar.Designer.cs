namespace PL.Cliente
{
    partial class CAgregar
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(39, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombres :";
            this.labelNombre.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelApellido.Location = new System.Drawing.Point(39, 105);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(56, 17);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellidos :";
            this.labelApellido.UseCompatibleTextRendering = true;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDireccion.Location = new System.Drawing.Point(39, 166);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(58, 13);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección :";
            this.labelDireccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDNI.Location = new System.Drawing.Point(39, 232);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDNI.Size = new System.Drawing.Size(30, 17);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "DNI :";
            this.labelDNI.UseCompatibleTextRendering = true;
            this.labelDNI.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrar.Location = new System.Drawing.Point(53, 279);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 53);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelar.Location = new System.Drawing.Point(178, 279);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 53);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PL.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(310, 364);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombre);
            this.Name = "CAgregar";
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}