using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Ventas
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();

            Font font = new Font("Arial", 30.0f);

            labelVenta.Font = font;
            labelVenta.ForeColor = Color.Green;
            #region Imagen
            pictureBox2.Image = Image.FromFile("ticket.jpg");
            pictureBox2.BackColor = Color.Transparent;
            #endregion
            

            
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Vender_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
