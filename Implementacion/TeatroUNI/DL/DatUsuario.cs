using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;

namespace DL
{
    public class DatUsuario
    {
        public int Insertar(USUARIO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.USUARIO.Add(P);
                ct.SaveChanges();
                return P.CUsuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Actualizar(USUARIO P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == P.CUsuario).SingleOrDefault();

                if (USUARIO != null)
                {
                    ct.Entry(USUARIO).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void Eliminar(int CUsuario)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == CUsuario).SingleOrDefault();
                if (USUARIO != null)
                {
                    ct.USUARIO.Remove(USUARIO);
                    ct.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<USUARIO> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.USUARIO.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public USUARIO GetById(int CUsuario)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                USUARIO USUARIO = ct.USUARIO.Where(x => x.CUsuario == CUsuario).SingleOrDefault();

                return USUARIO;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
