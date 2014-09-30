using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using MappingDB;
namespace BL
{
    public class LoginController
    {
        public LoginController()
        {

        }
        public bool AutenticarUsuario(String Username,String Password)
        {
            try
            {
                EMPLEADO objEmpleado = new DatEmpleado().Autenticar(Username,Password);
                if (objEmpleado == null)
                    return false;
                else { return true; }
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}
