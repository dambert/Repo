using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;
namespace BL
{
    public class busEmpleado
    {
        public int Insertar(EMPLEADO P)
        {
            try
            {
                return new DatEmpleado().Insertar(P);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public void Actualizar(EMPLEADO P)
        {
            try
            {
                new DatEmpleado().Actualizar(P);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public void Eliminar(int CEmpleado)
        {
            try
            {
                new DatEmpleado().Eliminar(CEmpleado);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<EMPLEADO> Leer()
        {
            try
            {
                return new DatEmpleado().Leer();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public EMPLEADO GetById(int CEmpleado)
        {
            try
            {
                return new DatEmpleado().GetById(CEmpleado);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
