using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busCliente
    {
        public int Insertar(CLIENTE P, USUARIO P2)
        {

            try
            {
                return new DatCliente().Insertar(P,P2);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void Actualizar(CLIENTE P, USUARIO P2)
        {

            try
            {
                 new DatCliente().Actualizar(P,P2);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void Eliminar(int CCliente)
        {
            try
            {
                new DatCliente().Eliminar(CCliente);
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
                return new DatCliente().Leer();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public dynamic GetById(int CCliente)
        {
            try
            {
                return new DatCliente().GetById(CCliente);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
