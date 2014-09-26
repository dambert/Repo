using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatAsiento_Evento
    {/*
        public int Insertar(ASIENTO_EVENTO P)
        {

            ContextoDB ct = new ContextoDB();
            ct.ASIENTO_EVENTO.Add(P);
            ct.SaveChanges();
            return P.CASIENTO_EVENTO;
        }
        public void Actualizar(ASIENTO_EVENTO P)
        {

            ContextoDB ct = new ContextoDB();
            ASIENTO_EVENTO ASIENTO_EVENTO = ct.ASIENTO_EVENTO.Where(x => x.CASIENTO_EVENTO == P.CASIENTO_EVENTO).SingleOrDefault();

            if (ASIENTO_EVENTO != null)
            {
                ct.Entry(ASIENTO_EVENTO).CurrentValues.SetValues(P);
                ct.SaveChanges();
            }
        }
        public void Eliminar(int CASIENTO_EVENTO)
        {
            ContextoDB ct = new ContextoDB();
            ASIENTO_EVENTO ASIENTO_EVENTO = ct.ASIENTO_EVENTO.Where(x => x.CASIENTO_EVENTO == CASIENTO_EVENTO).SingleOrDefault();
            if (ASIENTO_EVENTO != null)
            {
                ct.ASIENTO_EVENTO.Remove(ASIENTO_EVENTO);
                ct.SaveChanges();
            }
        }
        public List<ASIENTO_EVENTO> Leer()
        {
            ContextoDB ct = new ContextoDB();

            return ct.ASIENTO_EVENTO.ToList();


        }
        public ASIENTO_EVENTO GetById(int CASIENTO_EVENTO)
        {
            ContextoDB ct = new ContextoDB();
            ASIENTO_EVENTO ASIENTO_EVENTO = ct.ASIENTO_EVENTO.Where(x => x.CASIENTO_EVENTO == CASIENTO_EVENTO).SingleOrDefault();

            return ASIENTO_EVENTO;

        }*/
    }
}
