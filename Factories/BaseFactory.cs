using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public abstract class BaseFactory
    {
        public abstract MainBuilding creerMainBuilding();
        public abstract InfantryBuilding creerInfantryBuilding();
        public abstract GasBuilding creerGasBuilding();
    }
}
