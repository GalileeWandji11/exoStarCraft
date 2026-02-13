using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoStarCraft
{
    public class ProtossBase : Starcraft
    {
        public ProtossBase()
        {
            this.infantryBuilding = new Gateway();
            this.mainBuilding = new Nexus();
            this.gasBuilding = new Assimilator();
        }
    }
}
