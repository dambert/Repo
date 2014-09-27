using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busEvento
    {
        public int Insertar(EVENTO P)
        {
            try
            {
                return new DatEvento().Insertar(P);
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
                new DatEvento().Actualizar(P);
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
                new DatEvento().Eliminar(CEvento);
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
                return new DatEvento().Leer();
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
                return new DatEvento().GetById(CEvento);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
