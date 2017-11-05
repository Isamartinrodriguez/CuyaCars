using CuyaCars.OBJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuyaCars.DA
{
   //hjhjh
    
    public class DAClientes
    {
        CuyaCarsContext MiDBContext;

        public DAClientes()
        {
            MiDBContext = new CuyaCarsContext();
        }

        public void GuardarNuevoCliente(Cliente MiCliente)
        {
            using (var db = MiDBContext)
            {
                try
                {
                    db.Clientes.Add(MiCliente);
                    db.SaveChanges();
                }
                catch
                {

                }
                
                
           //     throw new System.ArgumentOutOfRangeException("X is too large");
            }
        }

        public List<Cliente> RecuperarClientes()
        {
            List<Cliente> MiListaClientes = new List<Cliente>();
            using (var db = MiDBContext)
            {
                var MisClientes = from Cliente in db.Clientes
                                  orderby Cliente.Nombre
                                  select Cliente;
               
             MiListaClientes = MisClientes.ToList();
            }

            return MiListaClientes;
        }

        public int DABuscarCliente( Cliente MiCliente)
        {
            int Resultado;
            using (var db = MiDBContext)
            {
                if (db.Clientes.Find(MiCliente.DNI) == null)
                {
                    Resultado = 0;
                    return Resultado;
                }
                else
                {
                    Resultado = 1;
                }
                return Resultado;
            }
        }

        public void DABorrarCliente(Cliente MiCliente)
        {
            using (var db = MiDBContext)
            {
                var MisClientes = from Cliente in db.Clientes
                                  where Cliente.DNI == MiCliente.DNI
                                  select Cliente;

                foreach (var ElClienteaborrar in MisClientes)
                {
                    db.Clientes.Remove(ElClienteaborrar);
                }

                try
                {
                     db.SaveChanges();
                }

                catch
                {

                }

            }
        }

        public Cliente DARecuperarCliente( Cliente MiCliente)
        {
            Cliente ElCliente = new Cliente();
           

            using (var db = MiDBContext)
            {
                var MisClientes = from Cliente in db.Clientes
                                  where Cliente.DNI == MiCliente.DNI
                                  select Cliente;

                foreach (var ElClientearecuperar in MisClientes)
                {
                   ElCliente = ElClientearecuperar;                               
                }

                try
                {
                    db.SaveChanges();
                }

                catch
                {

                }

            }
           return ElCliente;
        }


        public void BAActualizardato(Cliente MiCliente)
        {
            Cliente ElCliente = new Cliente();
            using (var db = MiDBContext)
            {
                var MisClientes = from Cliente in db.Clientes
                                  where Cliente.DNI == MiCliente.DNI
                                  select Cliente;

                foreach (var ElClienteaactualizar in MisClientes)
                {
                    ElClienteaactualizar.Nombre = MiCliente.Nombre;
                    //ElCliente = ElClienteaactualizar;
                }

                try
                {
                    db.SaveChanges();
                }

                catch
                {

                }
            }
        }
    }
}

