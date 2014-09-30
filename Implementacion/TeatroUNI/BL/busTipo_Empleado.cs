using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class DatTIPOEMPLEADO
    {
        public int Insertar(TIPOEMPLEADO P)
        {
            try
            {
                return new DatTIPOEMPLEADO().Insertar(P);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(TIPOEMPLEADO P)
        {
            try
            {
                new DatTIPOEMPLEADO().Actualizar(P);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CTipoEmpleado)
        {
            try
            {
                new DatTIPOEMPLEADO().Eliminar(CTipoEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<TIPOEMPLEADO> Leer()
        {
            try
            {
                return new DatTIPOEMPLEADO().Leer();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public TIPOEMPLEADO GetById(int CTipoEmpleado)
        {
            try
            {
                return new DatTIPOEMPLEADO().GetById(CTipoEmpleado);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
