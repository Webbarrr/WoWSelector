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
                // get the character to play
                var controller = new SelectorController();
                var randomCharacter = controller.GetRandomRace();

                // tell the user
                var grammar = IsVowel(randomCharacter.Name.ToString()[0]) ? "an" : "a";
                Console.WriteLine($"For the {randomCharacter.Faction}!");
                Console.WriteLine($"You will play {grammar} {randomCharacter.Name} {randomCharacter.Type}.");

                // see if they want to go again
                Console.WriteLine("Try again? Y/N?");
                var response = Console.ReadLine();

                if (response.ToLower() == "n" || response.ToLower() != "y")
                    break;

                Console.WriteLine();
            }

            Console.WriteLine("Hit any key to exit.");
            Console.ReadLine();
        }

        private static bool IsVowel(char character)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            foreach (var vowel in vowels)
            {
                if (character == vowel)
                    return true;
            }

            return false;
        }
    }
}