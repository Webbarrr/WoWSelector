using System.Collections.Generic;
using WoWSelector.Library.Races;

namespace WoWSelector.Library.Factions
{

    public class Alliance : IFaction
    {
        public List<IRace> GetRaces()
        {
            var races = new List<IRace>
            {
                new Human(),
                new Dwarf(),
                new NightElf(),
                new Gnome()
            };


            return races;
        }
    }
}
