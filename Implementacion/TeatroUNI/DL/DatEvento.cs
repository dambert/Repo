using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatEvento
    {
        public int Insertar(EVENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.EVENTO.Add(P);
                ct.SaveChanges();
                return P.CEvento;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(EVENTO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EVENTO EVENTO = ct.EVENTO.Where(x => x.CEvento == P.CEvento).SingleOrDefault();

                if (EVENTO != null)
                {
                    ct.Entry(EVENTO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CEvento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EVENTO EVENTO = ct.EVENTO.Where(x => x.CEvento == CEvento).SingleOrDefault();
                if (EVENTO != null)
                {
                    ct.EVENTO.Remove(EVENTO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<EVENTO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.EVENTO.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public EVENTO GetById(int CEvento)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EVENTO EVENTO = ct.EVENTO.Where(x => x.CEvento == CEvento).SingleOrDefault();

                return EVENTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
