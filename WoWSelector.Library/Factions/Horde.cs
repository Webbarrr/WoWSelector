using System.Collections.Generic;
using WoWSelector.Library.Races;

namespace WoWSelector.Library.Factions
{
    public class Horde : IFaction
    {
        public List<IRace> GetRaces()
        {
            var races = new List<IRace>
            {
                new Orc(),
                new Troll(),
                new Tauren(),
                new Undead()
            };

            return races;
        }
    }
}
