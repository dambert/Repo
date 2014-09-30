using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using MappingDB;
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
            //EventoController objEventoC = new EventoController(this);
            //objEventoC.CrearTodo();
           /* AsientoButton objAsient = new AsientoButton();
            objAsient.crearAsientoButton(this);*/

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
            Login logion = new Login();
            logion.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eventos.ConsultarEvento frmConsultarEvento = new Eventos.ConsultarEvento();
            frmConsultarEvento.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
