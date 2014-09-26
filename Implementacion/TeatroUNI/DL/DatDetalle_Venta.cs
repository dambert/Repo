using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatDetalle_Venta
    {/*
        public int Insertar(DETALLE_VENTA P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.DETALLE_VENTA.Add(P);
                ct.SaveChanges();
                return P.CDETALLE_VENTA;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(DETALLE_VENTA P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = ct.DETALLE_VENTA.Where(x => x.CDETALLE_VENTA == P.CDETALLE_VENTA).SingleOrDefault();

                if (DETALLE_VENTA != null)
                {
                    ct.Entry(DETALLE_VENTA).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CDETALLE_VENTA)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = ct.DETALLE_VENTA.Where(x => x.CDETALLE_VENTA == CDETALLE_VENTA).SingleOrDefault();
                if (DETALLE_VENTA != null)
                {
                    ct.DETALLE_VENTA.Remove(DETALLE_VENTA);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<DETALLE_VENTA> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.DETALLE_VENTA.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public DETALLE_VENTA GetById(int CDETALLE_VENTA)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = ct.DETALLE_VENTA.Where(x => x.CDETALLE_VENTA == CDETALLE_VENTA).SingleOrDefault();

                return DETALLE_VENTA;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }*/
    }
}
