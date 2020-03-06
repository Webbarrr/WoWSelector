using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Dwarf : AllianceBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}
