using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busAsiento_Evento
    {
        public void Insertar(ASIENTO_EVENTO P)
        {

            try
            {
                new DatAsiento_Evento().Insertar(P);
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
                new DatAsiento_Evento().Actualizar(P);
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
                new DatAsiento_Evento().Eliminar(CAsiento, CEvento);
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
                return new DatAsiento_Evento().Leer();
            }
            catch (Exception e)
            {

                throw e;
            };


        }
        public ASIENTO_EVENTO GetById(int CAsiento, int CEvento)
        {
            try
            {
                return new DatAsiento_Evento().GetById(CAsiento, CEvento);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
