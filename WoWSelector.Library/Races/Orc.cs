using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Orc : HordeBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}