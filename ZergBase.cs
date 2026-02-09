using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoStarCraft
{
    public class ZergBase : Starcraft
    {
        public ZergBase()
        {
            this.infantryBuilding = new ZergInfantryBuilding();
            this.mainBuilding = new ZergMainBuilding();
            this.gasBuilding = new ZergGasBuilding();
        }
    }
}
