using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Cliente
{
    public partial class CAgregar : Form
    {
        public CAgregar()
        {
            InitializeComponent();
            #region Labels
            //Tipo de letra de los label1y2
            Font font = new Font("Arial", 12.0f);

            labelNombre.Font = font;
            labelApellido.Font = font;
            labelDireccion.Font = font;
            labelDNI.Font = font;
            labelNombre.BackColor = Color.Transparent;
            labelApellido.BackColor = Color.Transparent;
            labelDireccion.BackColor = Color.Transparent;
            labelDNI.BackColor = Color.Transparent;

            labelNombre.Font = new System.Drawing.Font(labelNombre.Font, FontStyle.Bold);
            labelApellido.Font = new System.Drawing.Font(labelApellido.Font, FontStyle.Bold);
            labelDireccion.Font = new System.Drawing.Font(labelDireccion.Font, FontStyle.Bold); ;
            labelDNI.Font = new System.Drawing.Font(labelDNI.Font, FontStyle.Bold);


           
        
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
