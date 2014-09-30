using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatVenta
    {
        public int Insertar(VENTA P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.VENTA.Add(P);
                ct.SaveChanges();
                return P.CVenta;
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
                ContextoDB ct = new ContextoDB();
                VENTA VENTA = ct.VENTA.Where(x => x.CVenta == P.CVenta).SingleOrDefault();

                if (VENTA != null)
                {
                    ct.Entry(VENTA).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();
                VENTA VENTA = ct.VENTA.Where(x => x.CVenta == CVenta).SingleOrDefault();
                if (VENTA != null)
                {
                    ct.VENTA.Remove(VENTA);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();

                return ct.VENTA.ToList();
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
                ContextoDB ct = new ContextoDB();
                VENTA VENTA = ct.VENTA.Where(x => x.CVenta == CVenta).SingleOrDefault();

                return VENTA;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
