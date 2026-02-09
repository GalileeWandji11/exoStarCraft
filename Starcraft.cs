using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public abstract class Starcraft 
    {
        protected MainBuilding mainBuilding;
        protected InfantryBuilding infantryBuilding;
        protected GasBuilding gasBuilding;

        public InfantryBuilding getInfantryBuilding()
        {
            return infantryBuilding;
        }
    }
}
