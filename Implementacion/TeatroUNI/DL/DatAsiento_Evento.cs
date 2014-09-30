using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatAsiento_Evento
    {
        public void Insertar(ASIENTO_EVENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.ASIENTO_EVENTO.Add(P);
                ct.SaveChanges();
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public void Actualizar(ASIENTO_EVENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO_EVENTO ASIENTO_EVENTO = (from x in ct.ASIENTO_EVENTO
                                                 where x.CASiento == P.CASiento && x.CEvento == P.CEvento
                                                 select x).FirstOrDefault();

                if (ASIENTO_EVENTO != null)
                {
                    ct.Entry(ASIENTO_EVENTO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public void Eliminar(int CAsiento,int CEvento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO_EVENTO ASIENTO_EVENTO = (from x in ct.ASIENTO_EVENTO
                                                 where x.CASiento == CAsiento && x.CEvento == CEvento
                                                 select x).FirstOrDefault();
                if (ASIENTO_EVENTO != null)
                {
                    ct.ASIENTO_EVENTO.Remove(ASIENTO_EVENTO);
                    ct.SaveChanges();
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public List<ASIENTO_EVENTO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.ASIENTO_EVENTO.ToList();
            }
            catch (Exception e)
            {
                
                throw e;
            }



        }
        public ASIENTO_EVENTO GetById(int CAsiento, int CEvento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ASIENTO_EVENTO ASIENTO_EVENTO = (from x in ct.ASIENTO_EVENTO
                                                 where x.CASiento == CAsiento && x.CEvento == CEvento
                                                 select x).FirstOrDefault();

                return ASIENTO_EVENTO;
            }
            catch (Exception e)
            {
                
                throw e;
            }


        }
    }
}
