using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class UPCTicket : Form
    {
        public UPCTicket()
        {
            InitializeComponent();
        }

        private void UPCTicket_Load(object sender, EventArgs e)
        {
           
           
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          Ventas.Vender upc = new Ventas.Vender();
            upc.ShowDialog();
        }

        private void administrarCredencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.CAgregar frmAgregar = new Cliente.CAgregar();
            frmAgregar.ShowDialog();
        }

        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.EAgregar empleado = new Empleado.EAgregar();
            empleado.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.CListar frmListarCliente = new Cliente.CListar();
            frmListarCliente.ShowDialog();
        }

        private void cajeroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleado.EListar frmListarE = new Empleado.EListar();
            frmListarE.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.Hide();
            Principal logion = new Principal();
            logion.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eventos.ConsultarEvento frmConsultarEvento = new Eventos.ConsultarEvento();
            frmConsultarEvento.ShowDialog();
        }
    }
}
