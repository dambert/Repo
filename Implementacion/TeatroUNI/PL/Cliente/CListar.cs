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
    public partial class CListar : Form
    {
        public CListar()
        {
            InitializeComponent();
            Font font = new Font("Arial", 12.0f);

            LabelNombre.Font = font;
            label2.Font = font;

            LabelNombre.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;


            LabelNombre.Font = new System.Drawing.Font(LabelNombre.Font, FontStyle.Bold);
            label2.Font = new System.Drawing.Font(label2.Font, FontStyle.Bold);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
