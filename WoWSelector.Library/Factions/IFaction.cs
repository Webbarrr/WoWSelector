using System.Collections.Generic;
using WoWSelector.Library.Races;

namespace WoWSelector.Library.Factions
{
    public interface IFaction
    {
        List<IRace> GetRaces();
    }
}