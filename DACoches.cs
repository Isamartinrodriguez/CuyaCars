﻿using CuyaCars.OBJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//llkm,
namespace CuyaCars.DA
{
/knjknjk
    public class DACoches
    {
        CuyaCarsContext MiDBContext;

        public DACoches()
        {
            MiDBContext = new CuyaCarsContext();
        }


        public void AgregarBDCoches(Coche Micoche )
        {
            using (var db = MiDBContext)
            {
                db.Coches.Add(Micoche);
                db.SaveChanges();
            }
        }

    }

}
