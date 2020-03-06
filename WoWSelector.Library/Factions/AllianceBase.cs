using System.Collections.Generic;
using WoWSelector.Library.Classes;

namespace WoWSelector.Library.Races
{
    public class AllianceBase : ClassBase
    {
        public List<string> GetPlayableClasses()
        {
            var dict = new Dictionary<IRace, string>();

            var classes = new List<string>
            {
                Warrior,
                Paladin,
                Rogue,
                Priest,
                Mage,
                Warlock
            };
            foreach (var item in classes)
            {
                dict.Add(new Human(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Paladin,
                Hunter,
                Rogue,
                Priest
            };
            foreach (var item in classes)
            {
                dict.Add(new Dwarf(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Hunter,
                Rogue,
                Priest,
                Druid
            };
            foreach (var item in classes)
            {
                dict.Add(new NightElf(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Rogue,
                Mage,
                Warlock
            };
            foreach (var item in classes)
            {
                dict.Add(new Gnome(), item);
            }

            return this.GetPlayableCLasses(dict, this.GetType().Name);
        }
    }
}
