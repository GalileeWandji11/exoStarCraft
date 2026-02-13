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
            this.infantryBuilding = new SpawningPool();
            this.mainBuilding = new Hatchery();
            this.gasBuilding = new Extractor();
        }
    }
}
