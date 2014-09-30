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

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CListar_Load(object sender, EventArgs e)
        {

        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblBusqueda.Text = this.cmbBusqueda.Text;

            this.txtBusqueda.Enabled = true;
        }
    }
}
