using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busEstado_Asiento
    {
  
        public int Insertar(ESTADOASIENTO P)
        {
            try
            {
                return new DatEstado_Asiento().Insertar(P);
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
                new DatEstado_Asiento().Actualizar(P);
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
                new DatEstado_Asiento().Eliminar(CEstadoAsiento);
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
                return new DatEstado_Asiento().Leer();
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
                return new DatEstado_Asiento().GetById(CEstadoAsiento);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
