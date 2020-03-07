using Newtonsoft.Json;
using System.IO;

namespace WoWSelector.Library.Races
{
    public class Race
    {
        public RaceType Type { get; set; }
        public RaceName Name { get; set; }
        public RaceFaction Faction { get; set; }

        public Race()
        {
        }

        public Race(RaceType type, RaceName name, RaceFaction faction)
        {
            this.Type = type;
            this.Name = name;
            this.Faction = faction;
        }
    }
}