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
        public int Insertar(CLIENTE P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                ct.CLIENTE.Add(P);
                ct.SaveChanges();
                return P.CCliente;
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public void Actualizar(CLIENTE P)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == P.CCliente).SingleOrDefault();

                if (CLIENTE != null)
                {
                    ct.Entry(CLIENTE).CurrentValues.SetValues(P);
                    ct.SaveChanges();
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public void Eliminar(int CCliente)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == CCliente).SingleOrDefault();
                if (CLIENTE != null)
                {
                    ct.CLIENTE.Remove(CLIENTE);
                    ct.SaveChanges();
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public List<CLIENTE> Leer()
        {
            try
            {
                ContextoDB ct = new ContextoDB();

                return ct.CLIENTE.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }



        }
        public CLIENTE GetById(int CCliente)
        {
            try
            {
                ContextoDB ct = new ContextoDB();
                CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == CCliente).SingleOrDefault();

                return CLIENTE;
            }
            catch (Exception e)
            {
                
                throw e;
            }


        }
    }
}
