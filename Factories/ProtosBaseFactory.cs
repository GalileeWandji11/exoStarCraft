using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public class ProtosBaseFactory : BaseFactory
    {
        public override MainBuilding creerMainBuilding()
        {
            return new Nexus();
        }

        public override InfantryBuilding creerInfantryBuilding()
        {
            return new Gateway();
        }

        public override GasBuilding creerGasBuilding()
        {
            return new Assimilator();
        }
    }
}
