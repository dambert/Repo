using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatEmpleado
    {
        public int Insertar(EMPLEADO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.EMPLEADO.Add(P);
                ct.SaveChanges();
                return P.CEmpleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(EMPLEADO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EMPLEADO EMPLEADO = ct.EMPLEADO.Where(x => x.CEmpleado == P.CEmpleado).SingleOrDefault();

                if (EMPLEADO != null)
                {
                    ct.Entry(EMPLEADO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CEmpleado)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EMPLEADO EMPLEADO = ct.EMPLEADO.Where(x => x.CEmpleado == CEmpleado).SingleOrDefault();
                if (EMPLEADO != null)
                {
                    ct.EMPLEADO.Remove(EMPLEADO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<EMPLEADO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.EMPLEADO.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public EMPLEADO GetById(int CEmpleado)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EMPLEADO EMPLEADO = ct.EMPLEADO.Where(x => x.CEmpleado == CEmpleado).SingleOrDefault();

                return EMPLEADO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public EMPLEADO Autenticar(String Username,String Password)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                EMPLEADO EMPLEADO = (from x in ct.EMPLEADO
                                     where x.NUsername == Username && x.NPassword == Password
                                     select x).SingleOrDefault();

                return EMPLEADO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
