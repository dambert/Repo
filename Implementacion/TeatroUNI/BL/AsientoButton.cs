using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


using MappingDB;

namespace BL
{
    public class AsientoButton
    {
        private ASIENTO btnAsiento = null;
        private  TIPO_ASIENTO tipoAsiento= null;
        private int xPos;
        private int yPos;
        public AsientoButton(ASIENTO obj,TIPO_ASIENTO obj2)
        {
            
            this.btnAsiento = obj;
            this.tipoAsiento = obj2;
        }
        public AsientoButton()
        {
            //inicializar el tipoAsiento 
        }
        public void crearAsientoButton(Form MdiContainer)
        {
            Color[] c = { Color.Red, Color.Teal, Color.Blue, Color.WhiteSmoke };
            
            Button transbutton = new Button();
            transbutton.BackColor = Color.Red; //" this.tipoAsiento.NColor;"
            String textButton = btnAsiento.Letra + btnAsiento.Numero.ToString();
            transbutton.Text = textButton;
            transbutton.Name = "btn" + textButton;
            transbutton.Width = 50;
            transbutton.Height = 50;
            transbutton.Font = new Font("Segoe UI", 13);
            transbutton.ForeColor = Color.White;
            transbutton.Location = new Point(100, 100);
            transbutton.Click += new EventHandler(transbutton_Click);
            MdiContainer.Controls.Add(transbutton);
           
        }


        private void transbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberia abrir un formulario para manejar la butaca");
          
        }
        
        public ASIENTO getbtnAsiento() { return btnAsiento; }
        public void setbtnAsiento(ASIENTO obj) { this.btnAsiento = obj; }
        public TIPO_ASIENTO getTipoAsiento() { return tipoAsiento; }
        public void setTipoAsiento(ASIENTO obj) { this.tipoAsiento = obj; }

        public void setxPos(int xPos) { this.xPos = xPos; }
        public void setyPos(int yPos) { this.yPos = yPos; }

        public int getxPos() { return this.xPos; }
        public int getyPos() { return this.yPos; }
    }
}
