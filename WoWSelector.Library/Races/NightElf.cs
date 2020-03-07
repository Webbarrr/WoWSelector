using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class NightElf : AllianceBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}