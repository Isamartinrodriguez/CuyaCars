using CuyaCars.OBJ;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CuyaCars.DA
{
    public class CuyaCarsContext : DbContext
    {
        public DbSet<Coche> Coches { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }

    

}
