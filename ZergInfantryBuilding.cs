using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public class ZergInfantryBuilding : InfantryBuilding
    {
        public ZergInfantryBuilding()
        {
            Console.WriteLine("Construction d'un Spawning Pool (Zerg)");
        }

        public override Unit creerLargeUnit()
        {
            return new Guardian();
        }

        public override Unit creerMediumUnit()
        {
            return new Hydralisk();
        }

        public override Unit creerSmallUnit()
        {
            return new Zergling();
        }
    }
}
