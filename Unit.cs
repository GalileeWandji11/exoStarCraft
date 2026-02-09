using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public abstract class Unit
    {
        public UnitType type;
        public enum UnitType
        {
            SMALL_GROUND,
            MEDIUM_GROUND,
            LARGE_AIR
        }
    }
}
