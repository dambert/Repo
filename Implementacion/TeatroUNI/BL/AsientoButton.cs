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
        
        private int xPos;
        private int yPos;

        public AsientoButton(ASIENTO obj)
        {            
            this.btnAsiento = obj;
        }
        public AsientoButton()
        {
            //inicializar el tipoAsiento 
        }
        private Color getColor(int? ctipoAsiento)
        {
            switch(ctipoAsiento)
            {
                case 1: { return Color.Pink; } 
                case 2: { return Color.Blue; }
                case 3: { return Color.Green; }
                case 4: { return Color.DarkRed; }
                case 5: { return Color.Purple; }
                case 6: { return Color.Red; }
                case 7: { return Color.Yellow; }
                case 8: { return Color.Black; } 
            }

            return Color.Black;
        }
        public void crearAsientoButton(Form MdiContainer)
        {
                       
            Button transbutton = new Button();
            transbutton.BackColor = this.getColor(btnAsiento.CTipoAsiento);
            String textButton = btnAsiento.Letra + btnAsiento.Numero.ToString();
            transbutton.Text = textButton;
            transbutton.Name = "btn" + textButton;
            transbutton.Width = 23;
            transbutton.Height = 30;
            transbutton.Font = new Font("Arial Black", 5);
            transbutton.ForeColor = Color.White;
            transbutton.Location = new Point(this.xPos,this.yPos);
            transbutton.Click += new EventHandler(transbutton_Click);
            MdiContainer.Controls.Add(transbutton);
           
        }

       
        private void transbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberia abrir un formulario para manejar la butaca");
          
        }/*
        private void guardarAsientos()
        {
            busAsiento objbusAsiento = new busAsiento();
            objbusAsiento.Insertar(btnAsiento);
        }*/
        
        public ASIENTO getbtnAsiento() { return btnAsiento; }
        public void setbtnAsiento(ASIENTO obj) { this.btnAsiento = obj; }


        public void setxPos(int xPos) { this.xPos = xPos; }
        public void setyPos(int yPos) { this.yPos = yPos; }

        public int getxPos() { return this.xPos; }
        public int getyPos() { return this.yPos; }
    }
}
