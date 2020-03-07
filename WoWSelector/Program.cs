using System;
using WoWSelector.Library;

namespace WoWSelector
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                var controller = new SelectorController();

                // get the faction
                var faction = controller.GetFaction();

                // get the race
                var race = controller.GetRace(faction);

                // get the class
                var classToPlay = controller.GetClass(race);

                // ?? profit
                Console.WriteLine($"For the {faction.GetType().Name}");
                Console.WriteLine($"You will play a {race.GetType().Name} {classToPlay}");

                Console.WriteLine("Try again? Y/N?");
                var response = Console.ReadLine();

                if (response.ToLower() == "n" || response.ToLower() != "y")
                    break;
            }

            Console.WriteLine("Hit any key to exit.");
            Console.ReadLine();
        }
    }
}