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
namespace PL.ButacasxEvento
{
    public partial class ButacasxEventoVenta : Form
    {
        public ButacasxEventoVenta()
        {
            InitializeComponent();
        }

        private void ButacasxEventoVenta_Load(object sender, EventArgs e)
        {
            EventoController objEventoC = new EventoController(this);
        }
    }
}
