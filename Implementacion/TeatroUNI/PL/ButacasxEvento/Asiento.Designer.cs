namespace PL.Butacas
{
    partial class Asiento
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
            this.btnOk = new System.Windows.Forms.Button();
            this.labelTipoAsiento = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtSuperVip = new System.Windows.Forms.RadioButton();
            this.rdbVip = new System.Windows.Forms.RadioButton();
            this.rdbPlatinum = new System.Windows.Forms.RadioButton();
            this.rdbPreferencial = new System.Windows.Forms.RadioButton();
            this.rdbBasico = new System.Windows.Forms.RadioButton();
            this.rdbPopular = new System.Windows.Forms.RadioButton();
            this.rdbBloqueado = new System.Windows.Forms.RadioButton();
            this.labrlCodigo1 = new System.Windows.Forms.Label();
            this.txtCodigo01 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(425, 207);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // labelTipoAsiento
            // 
            this.labelTipoAsiento.AutoSize = true;
            this.labelTipoAsiento.BackColor = System.Drawing.SystemColors.Control;
            this.labelTipoAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAsiento.ForeColor = System.Drawing.Color.Chocolate;
            this.labelTipoAsiento.Location = new System.Drawing.Point(333, 29);
            this.labelTipoAsiento.Name = "labelTipoAsiento";
            this.labelTipoAsiento.Size = new System.Drawing.Size(213, 20);
            this.labelTipoAsiento.TabIndex = 5;
            this.labelTipoAsiento.Text = "Escoja el tipo de Asiento:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(485, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtSuperVip
            // 
            this.rbtSuperVip.AutoSize = true;
            this.rbtSuperVip.Location = new System.Drawing.Point(328, 109);
            this.rbtSuperVip.Name = "rbtSuperVip";
            this.rbtSuperVip.Size = new System.Drawing.Size(68, 17);
            this.rbtSuperVip.TabIndex = 7;
            this.rbtSuperVip.TabStop = true;
            this.rbtSuperVip.Text = "SuperVip";
            this.rbtSuperVip.UseVisualStyleBackColor = true;
            // 
            // rdbVip
            // 
            this.rdbVip.AutoSize = true;
            this.rdbVip.Location = new System.Drawing.Point(328, 66);
            this.rdbVip.Name = "rdbVip";
            this.rdbVip.Size = new System.Drawing.Size(42, 17);
            this.rdbVip.TabIndex = 8;
            this.rdbVip.TabStop = true;
            this.rdbVip.Text = "Víp";
            this.rdbVip.UseVisualStyleBackColor = true;
            // 
            // rdbPlatinum
            // 
            this.rdbPlatinum.AutoSize = true;
            this.rdbPlatinum.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbPlatinum.Location = new System.Drawing.Point(404, 109);
            this.rdbPlatinum.Name = "rdbPlatinum";
            this.rdbPlatinum.Size = new System.Drawing.Size(65, 17);
            this.rdbPlatinum.TabIndex = 9;
            this.rdbPlatinum.TabStop = true;
            this.rdbPlatinum.Text = "Platinum";
            this.rdbPlatinum.UseVisualStyleBackColor = true;
            this.rdbPlatinum.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdbPreferencial
            // 
            this.rdbPreferencial.AutoSize = true;
            this.rdbPreferencial.Location = new System.Drawing.Point(410, 155);
            this.rdbPreferencial.Name = "rdbPreferencial";
            this.rdbPreferencial.Size = new System.Drawing.Size(81, 17);
            this.rdbPreferencial.TabIndex = 10;
            this.rdbPreferencial.TabStop = true;
            this.rdbPreferencial.Text = "Preferencial";
            this.rdbPreferencial.UseVisualStyleBackColor = true;
            // 
            // rdbBasico
            // 
            this.rdbBasico.AutoSize = true;
            this.rdbBasico.Location = new System.Drawing.Point(404, 66);
            this.rdbBasico.Name = "rdbBasico";
            this.rdbBasico.Size = new System.Drawing.Size(57, 17);
            this.rdbBasico.TabIndex = 11;
            this.rdbBasico.TabStop = true;
            this.rdbBasico.Text = "Básico";
            this.rdbBasico.UseVisualStyleBackColor = true;
            // 
            // rdbPopular
            // 
            this.rdbPopular.AutoSize = true;
            this.rdbPopular.Location = new System.Drawing.Point(485, 66);
            this.rdbPopular.Name = "rdbPopular";
            this.rdbPopular.Size = new System.Drawing.Size(61, 17);
            this.rdbPopular.TabIndex = 12;
            this.rdbPopular.TabStop = true;
            this.rdbPopular.Text = "Popular";
            this.rdbPopular.UseVisualStyleBackColor = true;
            // 
            // rdbBloqueado
            // 
            this.rdbBloqueado.AutoSize = true;
            this.rdbBloqueado.Location = new System.Drawing.Point(328, 155);
            this.rdbBloqueado.Name = "rdbBloqueado";
            this.rdbBloqueado.Size = new System.Drawing.Size(76, 17);
            this.rdbBloqueado.TabIndex = 13;
            this.rdbBloqueado.TabStop = true;
            this.rdbBloqueado.Text = "Bloqueado";
            this.rdbBloqueado.UseVisualStyleBackColor = true;
            // 
            // labrlCodigo1
            // 
            this.labrlCodigo1.AutoSize = true;
            this.labrlCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrlCodigo1.Location = new System.Drawing.Point(37, 79);
            this.labrlCodigo1.Name = "labrlCodigo1";
            this.labrlCodigo1.Size = new System.Drawing.Size(152, 18);
            this.labrlCodigo1.TabIndex = 0;
            this.labrlCodigo1.Text = "Ingrese su código :";
            // 
            // txtCodigo01
            // 
            this.txtCodigo01.Location = new System.Drawing.Point(209, 80);
            this.txtCodigo01.Name = "txtCodigo01";
            this.txtCodigo01.Size = new System.Drawing.Size(79, 20);
            this.txtCodigo01.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo01);
            this.groupBox1.Controls.Add(this.labrlCodigo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 269);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 301);
            this.Controls.Add(this.rdbBloqueado);
            this.Controls.Add(this.rdbPreferencial);
            this.Controls.Add(this.labelTipoAsiento);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rdbVip);
            this.Controls.Add(this.rdbBasico);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbPopular);
            this.Controls.Add(this.rbtSuperVip);
            this.Controls.Add(this.rdbPlatinum);
            this.Controls.Add(this.groupBox1);
            this.Name = "Asiento";
            this.Text = "Asiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labelTipoAsiento;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtSuperVip;
        private System.Windows.Forms.RadioButton rdbVip;
        private System.Windows.Forms.RadioButton rdbPlatinum;
        private System.Windows.Forms.RadioButton rdbPreferencial;
        private System.Windows.Forms.RadioButton rdbBasico;
        private System.Windows.Forms.RadioButton rdbPopular;
        private System.Windows.Forms.RadioButton rdbBloqueado;
        private System.Windows.Forms.Label labrlCodigo1;
        private System.Windows.Forms.TextBox txtCodigo01;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}