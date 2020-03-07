using System.Collections.Generic;
using WoWSelector.Library.Classes;

namespace WoWSelector.Library.Races
{
    public class HordeBase : ClassBase
    {
        public List<string> GetPlayableClasses()
        {
            var dict = new Dictionary<IRace, string>();

            var classes = new List<string>
            {
                Warrior,
                Hunter,
                Rogue,
                Shaman,
                Warlock
            };
            foreach (var item in classes)
            {
                dict.Add(new Orc(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Rogue,
                Priest,
                Mage,
                Warlock
            };
            foreach (var item in classes)
            {
                dict.Add(new Undead(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Hunter,
                Shaman,
                Druid
            };
            foreach (var item in classes)
            {
                dict.Add(new Tauren(), item);
            }

            classes = new List<string>
            {
                Warrior,
                Hunter,
                Rogue,
                Priest,
                Shaman,
                Mage
            };
            foreach (var item in classes)
            {
                dict.Add(new Troll(), item);
            }

            return this.GetPlayableCLasses(dict, this.GetType().Name);
        }
    }
}