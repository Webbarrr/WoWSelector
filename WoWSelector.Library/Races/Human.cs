using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Human : AllianceBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}