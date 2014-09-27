using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
namespace DL
{
    public class DatCliente
    {
        public int Insertar(CLIENTE P, USUARIO P2)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.USUARIO.Add(P2);
                P.CCliente = P2.CUsuario;
                ct.CLIENTE.Add(P);
                ct.SaveChanges();
                return P.CCliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(CLIENTE P, USUARIO P2)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == P2.CUsuario).SingleOrDefault();
                CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == P.CCliente).SingleOrDefault();
                if (CLIENTE != null && USUARIO != null)
                {

                    ct.Entry(CLIENTE).CurrentValues.SetValues(P);
                    ct.Entry(USUARIO).CurrentValues.SetValues(P2);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CCliente)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == CCliente).SingleOrDefault();
                CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == CCliente).SingleOrDefault();
                if (CLIENTE != null && USUARIO != null)
                {

                    ct.CLIENTE.Remove(CLIENTE);
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
                var cliente = (from s in ct.USUARIO
                               join sa in ct.CLIENTE on s.CUsuario equals sa.CCliente
                                select s).ToList();
                return cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public dynamic GetById(int CCliente)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                var cliente =  (from s in ct.USUARIO
                               join sa in ct.CLIENTE on s.CUsuario equals sa.CCliente
                                where s.CUsuario == CCliente
                                select s).SingleOrDefault();

                return cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
