
// Galilée Wandji et Victor Léveillé

namespace exoStarCraft
{
    public class Program
    {
        private static void test(Starcraft starcraft)
        {
            // ...
            Unit smallGround = starcraft.getInfantryBuilding().creerUnit(Unit.UnitType.SMALL_GROUND);
            Unit mediumGround = starcraft.getInfantryBuilding().creerUnit(Unit.UnitType.MEDIUM_GROUND);
            Unit largeAir = starcraft.getInfantryBuilding().creerUnit(Unit.UnitType.LARGE_AIR);
            // ...
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("--- Protoss ---");
            test(new ProtossBase());
            Console.WriteLine("------");
            Console.WriteLine("--- Zerg ---");
            test(new ZergBase());
            Console.WriteLine("------");
        }

    }
}
