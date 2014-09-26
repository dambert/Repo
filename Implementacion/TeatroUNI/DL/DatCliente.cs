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

            ContextoDB ct = new ContextoDB();   
            ct.CLIENTE.Add(P);
            ct.SaveChanges();
            return P.CCliente;
        }
        public void Actualizar(CLIENTE P)
        {

            ContextoDB ct = new ContextoDB();
            CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == P.CCliente).SingleOrDefault();

            if (CLIENTE != null)
            {
                ct.Entry(CLIENTE).CurrentValues.SetValues(P);
                ct.SaveChanges();
            }
        }
        public void Eliminar(int CCliente)
        {
            ContextoDB ct = new ContextoDB();
            CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == CCliente).SingleOrDefault();
            if (CLIENTE != null)
            {
                ct.CLIENTE.Remove(CLIENTE);
                ct.SaveChanges();
            }
        }
        public List<CLIENTE> Leer()
        {
            ContextoDB ct = new ContextoDB();

            return ct.CLIENTE.ToList();


        }
        public CLIENTE GetById(int CCliente)
        {
            ContextoDB ct = new ContextoDB();
            CLIENTE CLIENTE = ct.CLIENTE.Where(x => x.CCliente == CCliente).SingleOrDefault();

            return CLIENTE;

        }
    }
}
