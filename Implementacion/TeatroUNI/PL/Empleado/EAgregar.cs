using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Empleado
{
    public partial class EAgregar : Form
    {
        public EAgregar()
        {
            InitializeComponent();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
