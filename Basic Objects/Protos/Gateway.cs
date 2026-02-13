using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public class Gateway : InfantryBuilding
    {
        public Gateway()
        {
            Console.WriteLine("Construction d'un Gateway (Protos)");
        }

        public override Unit creerLargeUnit()
        {
            return new Carrier();
        }

        public override Unit creerMediumUnit()
        {
            return new Dragoon();
        }

        public override Unit creerSmallUnit()
        {
            return new Zealot();
        }
    }
}
