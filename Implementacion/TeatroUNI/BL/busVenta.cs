using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busVenta
    {
        public int Insertar(VENTA P)
        {
            try
            {
                return new DatVenta().Insertar(P);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(VENTA P)
        {
            try
            {
                new DatVenta().Actualizar(P);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CVenta)
        {
            try
            {
                new DatVenta().Eliminar(CVenta);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<VENTA> Leer()
        {
            try
            {
                return new DatVenta().Leer();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public VENTA GetById(int CVenta)
        {
            try
            {
                return new DatVenta().GetById(CVenta);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
