using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Gnome : AllianceBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}