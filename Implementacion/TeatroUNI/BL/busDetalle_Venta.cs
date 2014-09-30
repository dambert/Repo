using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busDetalle_Venta
    {
        public void Insertar(DETALLE_VENTA P)
        {

            try
            {
                new DatDetalle_Venta().Insertar(P);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void Actualizar(DETALLE_VENTA P)
        {
            try
            {
                new DatDetalle_Venta().Actualizar(P);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void Eliminar(int CAsiento, int CVenta)
        {
            try
            {
                new DatDetalle_Venta().Eliminar(CAsiento, CVenta);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<DETALLE_VENTA> Leer()
        {
            try
            {
               return new DatDetalle_Venta().Leer();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public DETALLE_VENTA GetById(int CAsiento, int CVenta)
        {
            try
            {
                return new DatDetalle_Venta().GetById(CAsiento, CVenta);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
