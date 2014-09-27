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
        public int Insertar(CLIENTE P)
        {

            try
            {
                return new DatCliente().Insertar(P);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void Actualizar(CLIENTE P)
        {

            try
            {
                 new DatCliente().Actualizar(P);
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
        public List<CLIENTE> Leer()
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
        public CLIENTE GetById(int CCliente)
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
