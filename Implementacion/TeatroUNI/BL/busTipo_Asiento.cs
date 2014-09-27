using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busTipo_Asiento
    {
        public int Insertar(TIPO_ASIENTO P)
        {
            try
            {
                return new DatTipo_Asiento().Insertar(P);
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
                 new DatTipo_Asiento().Actualizar(P);
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
                new DatTipo_Asiento().Eliminar(CTipoAsiento);
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
                return new DatTipo_Asiento().Leer();
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
                return new DatTipo_Asiento().GetById(CTipoAsiento);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
