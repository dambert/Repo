using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MappingDB;
using System.Drawing;
namespace BL
{
    public class EventoController
    {
        //52
        private List<AsientoButton> lstAsientoButton=null;
        private char[,] PosButaca = new char[,] { 
              //1   2   3    4   5    6   7    8    9   10   11  12  13   14  15   16  17   18   19   20  21   22  23   24  25   26  27   28   29   30  31   32  33   34  35   36  37   38   39   40  41   42  43   44  45   46  47   48   49   50  51  52  53   54 55  56   57
            { 'E', 'E','E', 'E','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'E','E', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','E','E','E','E' },
            { 'E', 'E','E', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','E','E','E','E' },
            { 'E', 'E','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'E', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },   

            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','X','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','X','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','X','E','E' },

            { 'E', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','E', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'E', 'E','E', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X','X','X','X','E','E','E' },
            { 'E', 'E','E', 'E','E', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'E' ,'E', 'E','E', 'E','E', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'E', 'E','E', 'E','X', 'X','X', 'X','X', 'X','X', 'X' ,'X','X','E','E','E','E' ,'E','E','E' },   
            { 'E', 'E','E', 'E','E', 'E','X', 'X' ,'X', 'X','X', 'X','X', 'E','E', 'E','E' , 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'X','E', 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'E','E', 'E' ,'E', 'E','E','E','E','E','E' },
            { 'E', 'E','E', 'E','E', 'E','E', 'X' ,'X', 'X','X', 'X','X', 'E','E', 'E','E' , 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','X', 'X','X', 'X' ,'X', 'X','X', 'X','X', 'E','E', 'E','E', 'E' ,'X', 'X','X', 'X','X', 'X','E','E' ,'E', 'E' ,'E', 'E','E','E','E','E','E' }
            
            };
        public EventoController(Form mdiContainer)
        {
            //Inicializo mi lista de lista de asientos button
            lstAsientoButton = new List<AsientoButton>();

            //creo una instancia de bus asiento para recuperar la lista de asientos que tengo en la base de datos
            busAsiento objbusAsiento = new busAsiento();
            //llamo al metodo leer para recuperar todo la lista
            List<ASIENTO> lstAsientos=objbusAsiento.Leer();

            //necesito llenar la lista lstAsientoBUtton para lo cual tengo quer recorrer la lstAsientos e ir creandolos
            //asimismo de pasada tengo que asignarle una posición en pantalla para lo cual´haré uso de mi matriz que me hace referencia
            //de la posición en pantalla de los asientos
            int j = 0;
            int i = 0;
            foreach(ASIENTO objAsiento in lstAsientos)
            {
               
                AsientoButton objAsientoButton=new AsientoButton();

                while (this.PosButaca[j, i] == 'E')
                {
                    if (i < 56)
                    {
                        i++;

                        if(i>=56)
                        {
                            j++;
                            i = 0;
                        }
                    }
                    else
                    { 
                        break;
                    }
                }

                objAsientoButton.setxPos((i * 23));
                objAsientoButton.setyPos((j * 30) + 60 + (6 * j));
                objAsientoButton.setbtnAsiento(objAsiento);
                objAsientoButton.crearAsientoButton(mdiContainer);
                lstAsientoButton.Add(objAsientoButton);
                i++;

                if (i >= 56)
                {
                    j++;
                    i = 0;
                }
               
            }
           
        }
        public void CrearTodo()
        {
           /*for (int j = 0; j <= 15; j++)
            {
                for (int i = 0; i <= 51; i++)
                {
                   
                }

            }*/
        }
        public void CrearButacasParaEvento()
        {
        }
        public List<AsientoButton> getListAsientoButton()
        {
            return lstAsientoButton;
        }

    }
}
