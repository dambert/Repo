using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatAsiento
    {
        public int Insertar(ASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.ASIENTO.Add(P);
                ct.SaveChanges();
                return P.CASiento;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        public void Actualizar(ASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO ASIENTO = ct.ASIENTO.Where(x => x.CASiento == P.CASiento).SingleOrDefault();

                if (ASIENTO != null)
                {
                    ct.Entry(ASIENTO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        public void Eliminar(int CASiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO ASIENTO = ct.ASIENTO.Where(x => x.CASiento == CASiento).SingleOrDefault();
                if (ASIENTO != null)
                {
                    ct.ASIENTO.Remove(ASIENTO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
        public List<ASIENTO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.ASIENTO.ToList();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }



        }
        public ASIENTO GetById(int CASiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO ASIENTO = ct.ASIENTO.Where(x => x.CASiento == CASiento).SingleOrDefault();

                return ASIENTO;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }
    }
}
