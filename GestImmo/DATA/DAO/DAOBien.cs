using ConsoleApp.PostgreSQL;
using GestImmo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.DATA.DAO
{
    internal class DAOBien
    {

        public List<Bien> getBienAvecPret()
        {
            List<Bien> biens;

            GestImmoContext context = GestImmoContext.getInstance();
            var rows = from b in context.Biens
                       where b.Pret != null
                       select b;

            biens = rows.ToList();

            return biens;

        }




    }
}
