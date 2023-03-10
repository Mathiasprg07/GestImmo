using ConsoleApp.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.DATA.Models
{
    internal class ControllerFinance
    {
        public int calculerRentbiliteNetMensuelGlobale()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            List<Bien> biens=ctx.Biens.ToList();

            int revenuGlobal = 0;
            foreach (Bien bien in biens)
            {
                revenuGlobal = revenuGlobal + bien.calculerRentabiliteNetMensuel();
            }
                    
            return revenuGlobal;
        }
    }
}
