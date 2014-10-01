namespace PL.Butacas
{
    partial class Pisos
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
            this.rdbPiso1 = new System.Windows.Forms.RadioButton();
            this.rdbPiso2 = new System.Windows.Forms.RadioButton();
            this.LabelModificar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbPiso1
            // 
            this.rdbPiso1.AutoSize = true;
            this.rdbPiso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPiso1.Location = new System.Drawing.Point(37, 68);
            this.rdbPiso1.Name = "rdbPiso1";
            this.rdbPiso1.Size = new System.Drawing.Size(67, 20);
            this.rdbPiso1.TabIndex = 0;
            this.rdbPiso1.TabStop = true;
            this.rdbPiso1.Text = "PISO 1";
            this.rdbPiso1.UseVisualStyleBackColor = true;
            // 
            // rdbPiso2
            // 
            this.rdbPiso2.AutoSize = true;
            this.rdbPiso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPiso2.Location = new System.Drawing.Point(159, 68);
            this.rdbPiso2.Name = "rdbPiso2";
            this.rdbPiso2.Size = new System.Drawing.Size(67, 20);
            this.rdbPiso2.TabIndex = 1;
            this.rdbPiso2.TabStop = true;
            this.rdbPiso2.Text = "PISO 2";
            this.rdbPiso2.UseVisualStyleBackColor = true;
            // 
            // LabelModificar
            // 
            this.LabelModificar.AutoSize = true;
            this.LabelModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModificar.Location = new System.Drawing.Point(34, 13);
            this.LabelModificar.Name = "LabelModificar";
            this.LabelModificar.Size = new System.Drawing.Size(210, 18);
            this.LabelModificar.TabIndex = 2;
            this.LabelModificar.Text = "Que piso desea Modificar?";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(80, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // Pisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 185);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.LabelModificar);
            this.Controls.Add(this.rdbPiso2);
            this.Controls.Add(this.rdbPiso1);
            this.Name = "Pisos";
            this.Text = "Pisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPiso1;
        private System.Windows.Forms.RadioButton rdbPiso2;
        private System.Windows.Forms.Label LabelModificar;
        private System.Windows.Forms.Button btnModificar;
    }
}