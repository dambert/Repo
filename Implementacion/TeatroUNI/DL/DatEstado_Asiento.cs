using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatEstado_Asiento
    {
  
        public int Insertar(ESTADOASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.ESTADOASIENTO.Add(P);
                ct.SaveChanges();
                return P.CEstadoAsiento;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(ESTADOASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ESTADOASIENTO ESTADOASIENTO = ct.ESTADOASIENTO.Where(x => x.CEstadoAsiento == P.CEstadoAsiento).SingleOrDefault();

                if (ESTADOASIENTO != null)
                {
                    ct.Entry(ESTADOASIENTO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CEstadoAsiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ESTADOASIENTO ESTADOASIENTO = ct.ESTADOASIENTO.Where(x => x.CEstadoAsiento == CEstadoAsiento).SingleOrDefault();
                if (ESTADOASIENTO != null)
                {
                    ct.ESTADOASIENTO.Remove(ESTADOASIENTO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<ESTADOASIENTO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.ESTADOASIENTO.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public ESTADOASIENTO GetById(int CEstadoAsiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ESTADOASIENTO ESTADOASIENTO = ct.ESTADOASIENTO.Where(x => x.CEstadoAsiento == CEstadoAsiento).SingleOrDefault();

                return ESTADOASIENTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
