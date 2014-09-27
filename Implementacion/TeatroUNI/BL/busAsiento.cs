using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using MappingDB;
namespace BL
{
    public class busAsiento
    {
        public int Insertar(ASIENTO P)
        {
            try
            {
                return new DatAsiento().Insertar(P);
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

                new DatAsiento().Actualizar(P);
              
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
                new DatAsiento().Eliminar(CASiento);
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
                return new DatAsiento().Leer();
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
                return new DatAsiento().GetById(CASiento);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }
    }
}
