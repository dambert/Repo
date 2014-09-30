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
namespace PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            #region Imagen
            pictureBox1.Image = Image.FromFile("User.png");
            #endregion
            #region Labels
            //Tipo de letra de los label1y2
            Font font = new Font("Arial", 12.0f);
            
                label1.Font = font;
                label2.Font = font;
                label1.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;
                label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold); 
            #endregion
                #region PictureBox

                pictureBox1.BackColor = Color.Transparent;
                #endregion
                #region Boton
                //Tipo de letra del boton
            Font font2 = new Font("Arial", 10.0f);
            button1.Font = font2;
            button1.BackColor = Color.Red;
            #endregion

            #region Usuario
            txtUsuario.Text = "";
            txtUsuario.MaxLength = 10;
            #endregion
            #region Contraseña
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 14;
            #endregion

            //UPCTicket nuevoHilo = new UPCTicket();
           

        }
        private void RunPrincipal()
        {

            Login pri = new Login();
            pri.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            #region Alerta

            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                //Muestra mensaje de error
                MessageBox.Show("Introduce todos los datos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

              

            else 
            {

                LoginController lc = new LoginController();
                bool Validacion = lc.AutenticarUsuario(this.txtUsuario.Text, this.txtPassword.Text);

                if(Validacion==false)
                {
                    MessageBox.Show("Clave incorrecta");

                }
                else { 
                UPCTicket upc = new UPCTicket();
                upc.ShowDialog();
                }

                

             
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
  


            



      
    }
}
