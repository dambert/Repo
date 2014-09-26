using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatTIPOEMPLEADO
    {
        public int Insertar(TIPOEMPLEADO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.TIPOEMPLEADO.Add(P);
                ct.SaveChanges();
                return P.CTipoEmpleado;
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
                ContextoDB ct = new ContextoDB();
                TIPOEMPLEADO TIPOEMPLEADO = ct.TIPOEMPLEADO.Where(x => x.CTipoEmpleado == P.CTipoEmpleado).SingleOrDefault();

                if (TIPOEMPLEADO != null)
                {
                    ct.Entry(TIPOEMPLEADO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();
                TIPOEMPLEADO TIPOEMPLEADO = ct.TIPOEMPLEADO.Where(x => x.CTipoEmpleado == CTipoEmpleado).SingleOrDefault();
                if (TIPOEMPLEADO != null)
                {
                    ct.TIPOEMPLEADO.Remove(TIPOEMPLEADO);
                    ct.SaveChanges();
                }
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
                ContextoDB ct = new ContextoDB();

                return ct.TIPOEMPLEADO.ToList();
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
                ContextoDB ct = new ContextoDB();
                TIPOEMPLEADO TIPOEMPLEADO = ct.TIPOEMPLEADO.Where(x => x.CTipoEmpleado == CTipoEmpleado).SingleOrDefault();

                return TIPOEMPLEADO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
