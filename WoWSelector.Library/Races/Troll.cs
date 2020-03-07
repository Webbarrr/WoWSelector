using System.Collections.Generic;

namespace WoWSelector.Library.Races
{
    public class Troll : HordeBase, IRace
    {
        public List<string> GetClasses()
        {
            return this.GetPlayableClasses();
        }
    }
}