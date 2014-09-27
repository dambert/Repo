using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatDetalle_Venta
    {
        public void Insertar(DETALLE_VENTA P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.DETALLE_VENTA.Add(P);
                ct.SaveChanges();
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
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = (from x in ct.DETALLE_VENTA
                                               where x.CASiento == P.CASiento && x.CVenta == P.CVenta
                                               select x).FirstOrDefault();

                if (DETALLE_VENTA != null)
                {
                    ct.Entry(DETALLE_VENTA).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = (from x in ct.DETALLE_VENTA
                                               where x.CASiento == CAsiento && x.CVenta == CVenta
                                               select x).FirstOrDefault();
                if (DETALLE_VENTA != null)
                {
                    ct.DETALLE_VENTA.Remove(DETALLE_VENTA);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();

                return ct.DETALLE_VENTA.ToList();
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
                ContextoDB ct = new ContextoDB();
                DETALLE_VENTA DETALLE_VENTA = (from x in ct.DETALLE_VENTA
                                               where x.CASiento == CAsiento && x.CVenta == CVenta
                                               select x).FirstOrDefault();

                return DETALLE_VENTA;

            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
    }
}
