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
                var randomCharacter = controller.GetRandomRace();

                Console.WriteLine($"For the {randomCharacter.Faction}!");
                Console.WriteLine($"You will play a {randomCharacter.Name} {randomCharacter.Type}.");

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