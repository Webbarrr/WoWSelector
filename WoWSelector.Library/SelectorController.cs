using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWSelector.Library.Factions;
using WoWSelector.Library.Races;

namespace WoWSelector.Library
{
    public class SelectorController
    {
        private readonly Random random;

        public SelectorController()
        {
            random = new Random();
        }

        public IFaction GetFaction()
        {
            var factions = new List<IFaction>
            {
                new Alliance(),
                new Horde()
            };

            return factions[random.Next(0, factions.Count)];
        }

        public IRace GetRace(IFaction faction)
        {
            if (faction is null)
                throw new ArgumentNullException(nameof(faction));

            var races = faction.GetRaces();
            return races[random.Next(0, races.Count)];
        }

        public string GetClass(IRace race)
        {
            if (race is null)
                throw new ArgumentNullException(nameof(race));

            var classes = race.GetClasses();
            return classes[random.Next(0, classes.Count)];
        }
    }
}
