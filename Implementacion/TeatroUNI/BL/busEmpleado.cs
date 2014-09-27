using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busEmpleado
    {
        public int Insertar(EMPLEADO P, USUARIO P2)
        {
            try
            {
                return new DatEmpleado().Insertar(P,P2);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public void Actualizar(EMPLEADO P, USUARIO P2)
        {
            try
            {
                new DatEmpleado().Actualizar(P,P2);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public void Eliminar(int CEmpleado)
        {
            try
            {
                new DatEmpleado().Eliminar(CEmpleado);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public dynamic Leer()
        {
            try
            {
                return new DatEmpleado().Leer();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public dynamic GetById(int CEmpleado)
        {
            try
            {
                return new DatEmpleado().GetById(CEmpleado);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public EMPLEADO Autenticar(String Username, String Password)
        {
            try
            {
                return new DatEmpleado().Autenticar(Username, Password);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
