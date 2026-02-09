using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public class ZergBaseFactory : BaseFactory
    {
        public override MainBuilding creerMainBuilding()
        {
            return new ZergMainBuilding();
        }

        public override InfantryBuilding creerInfantryBuilding()
        {
            return new ZergInfantryBuilding();
        }

        public override GasBuilding creerGasBuilding()
        {
            return new ZergGasBuilding();
        }
    }
}
