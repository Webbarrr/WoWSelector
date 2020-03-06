using System.Collections.Generic;
using System.Linq;
using WoWSelector.Library.Races;

namespace WoWSelector.Library.Classes
{
    public class ClassBase
    {
        public const string Warrior = "Warrior";
        public const string Paladin = "Paladin";
        public const string Rogue = "Rogue";
        public const string Priest = "Priest";
        public const string Mage = "Mage";
        public const string Warlock = "Warlock";
        public const string Hunter = "Hunter";
        public const string Druid = "Druid";
        public const string Shaman = "Shaman";


        protected List<string> GetPlayableCLasses(Dictionary<IRace, string> keyValuePairs, string raceName)
        {
            var playableClasses = keyValuePairs.Where(d => d.Key.GetType().Name == raceName);
            var listOfPlayableClasses = new List<string>();
            foreach (var item in playableClasses)
            {
                listOfPlayableClasses.Add(item.Value);
            }

            return listOfPlayableClasses;
        }
    }
}
