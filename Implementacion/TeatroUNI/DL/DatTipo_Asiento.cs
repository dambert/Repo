using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatTipo_Asiento
    {
        public int Insertar(TIPO_ASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.TIPO_ASIENTO.Add(P);
                ct.SaveChanges();
                return P.CTipoAsiento;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(TIPO_ASIENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                TIPO_ASIENTO TIPO_ASIENTO = ct.TIPO_ASIENTO.Where(x => x.CTipoAsiento == P.CTipoAsiento).SingleOrDefault();

                if (TIPO_ASIENTO != null)
                {
                    ct.Entry(TIPO_ASIENTO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CTipoAsiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                TIPO_ASIENTO TIPO_ASIENTO = ct.TIPO_ASIENTO.Where(x => x.CTipoAsiento == CTipoAsiento).SingleOrDefault();
                if (TIPO_ASIENTO != null)
                {
                    ct.TIPO_ASIENTO.Remove(TIPO_ASIENTO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<TIPO_ASIENTO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.TIPO_ASIENTO.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public TIPO_ASIENTO GetById(int CTipoAsiento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                TIPO_ASIENTO TIPO_ASIENTO = ct.TIPO_ASIENTO.Where(x => x.CTipoAsiento == CTipoAsiento).SingleOrDefault();

                return TIPO_ASIENTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
