using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingDB;
using DL;

namespace BL
{
    public class busUsuario
    {
        public int Insertar(USUARIO P)
        {
            try
            {
                return new DatUsuario().Insertar(P);
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
                new DatUsuario().Actualizar(P);

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
                new DatUsuario().Eliminar(CUsuario);
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
                return new DatUsuario().Leer();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        /*public dynamic GetById(int CUsuario)
        {
            try
            {
                return new DatUsuario().GetById(CUsuario);

              
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }*/
    }
}
