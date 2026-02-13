using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public abstract class InfantryBuilding 
    {
        Unit unit;
        public Unit creerUnit(Unit.UnitType type)
        {
            switch (type)
            {
                case Unit.UnitType.SMALL_GROUND:
                    unit = creerSmallUnit();
                    break;
                case Unit.UnitType.MEDIUM_GROUND:
                    unit = creerMediumUnit();
                    break;
                case Unit.UnitType.LARGE_AIR:
                    unit = creerLargeUnit();
                    break;
                default:
                    break;
            }

            return unit;
        }

        public abstract Unit creerSmallUnit();
        public abstract Unit creerMediumUnit();
        public abstract Unit creerLargeUnit();
    }
}
