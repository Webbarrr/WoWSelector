using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Undead : HordeBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}
