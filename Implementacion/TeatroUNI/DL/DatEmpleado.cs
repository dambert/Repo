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
        public int Insertar(EMPLEADO P,USUARIO P2)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.USUARIO.Add(P2);
                P.CEmpleado = P2.CUsuario;
                ct.EMPLEADO.Add(P);
                ct.SaveChanges();
                return P.CEmpleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(EMPLEADO P, USUARIO P2)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == P2.CUsuario).SingleOrDefault();
                EMPLEADO EMPLEADO = ct.EMPLEADO.Where(x => x.CEmpleado == P.CEmpleado).SingleOrDefault();                
                if (EMPLEADO != null && USUARIO!=null)
                {
                   
                    ct.Entry(EMPLEADO).CurrentValues.SetValues(P);
                    ct.Entry(USUARIO).CurrentValues.SetValues(P2);
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
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == CEmpleado).SingleOrDefault();
                if (EMPLEADO != null && USUARIO != null)
                {
                   
                    ct.EMPLEADO.Remove(EMPLEADO);
                    ct.USUARIO.Remove(USUARIO);
                   
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public dynamic Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                var empleado = (from s in ct.USUARIO
                                join sa in ct.EMPLEADO on s.CUsuario equals sa.CEmpleado                               
                                select s).ToList();
                return empleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public dynamic GetById(int CEmpleado)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                var empleado = (from s in ct.USUARIO
                                join sa in ct.EMPLEADO on s.CUsuario equals sa.CEmpleado
                                where s.CUsuario==CEmpleado
                                select s).SingleOrDefault();

                return empleado;
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
