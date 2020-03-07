using System;
using System.Collections.Generic;
using WoWSelector.Library.Races;

namespace WoWSelector.Library
{
    public class SelectorController
    {
        private readonly List<Race> Races = new List<Race>();

        private readonly Random _random = new Random();

        private int RandomIndex => _random.Next(0, Races.Count - 1);

        private IEnumerable<Race> GetAlliance()
        {
            return new List<Race>
            {
                new Race(RaceType.Warrior, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Paladin, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Rogue, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Priest, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Mage, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Warlock, RaceName.Human, RaceFaction.Alliance),
                new Race(RaceType.Warrior, RaceName.Dwarf, RaceFaction.Alliance),
                new Race(RaceType.Paladin, RaceName.Dwarf, RaceFaction.Alliance),
                new Race(RaceType.Hunter, RaceName.Dwarf, RaceFaction.Alliance),
                new Race(RaceType.Rogue, RaceName.Dwarf, RaceFaction.Alliance),
                new Race(RaceType.Priest, RaceName.Dwarf, RaceFaction.Alliance),
                new Race(RaceType.Warrior, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Hunter, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Rogue, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Priest, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Druid, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Druid, RaceName.NightElf, RaceFaction.Alliance),
                new Race(RaceType.Warrior, RaceName.Gnome, RaceFaction.Alliance),
                new Race(RaceType.Rogue, RaceName.Gnome, RaceFaction.Alliance),
                new Race(RaceType.Mage, RaceName.Gnome, RaceFaction.Alliance),
                new Race(RaceType.Warlock, RaceName.Gnome, RaceFaction.Alliance)
            };
        }

        private IEnumerable<Race> GetHorde()
        {
            return new List<Race>
            {
                new Race(RaceType.Warrior, RaceName.Orc, RaceFaction.Horde),
                new Race(RaceType.Hunter, RaceName.Orc, RaceFaction.Horde),
                new Race(RaceType.Rogue, RaceName.Orc, RaceFaction.Horde),
                new Race(RaceType.Shaman, RaceName.Orc, RaceFaction.Horde),
                new Race(RaceType.Warlock, RaceName.Orc, RaceFaction.Horde),
                new Race(RaceType.Warrior, RaceName.Undead, RaceFaction.Horde),
                new Race(RaceType.Priest, RaceName.Undead, RaceFaction.Horde),
                new Race(RaceType.Rogue, RaceName.Undead, RaceFaction.Horde),
                new Race(RaceType.Mage, RaceName.Undead, RaceFaction.Horde),
                new Race(RaceType.Warlock, RaceName.Undead, RaceFaction.Horde),
                new Race(RaceType.Warrior, RaceName.Tauren, RaceFaction.Horde),
                new Race(RaceType.Hunter, RaceName.Tauren, RaceFaction.Horde),
                new Race(RaceType.Shaman, RaceName.Tauren, RaceFaction.Horde),
                new Race(RaceType.Druid, RaceName.Tauren, RaceFaction.Horde),
                new Race(RaceType.Warrior, RaceName.Troll, RaceFaction.Horde),
                new Race(RaceType.Hunter, RaceName.Troll, RaceFaction.Horde),
                new Race(RaceType.Rogue, RaceName.Troll, RaceFaction.Horde),
                new Race(RaceType.Priest, RaceName.Troll, RaceFaction.Horde),
                new Race(RaceType.Mage, RaceName.Troll, RaceFaction.Horde),
                new Race(RaceType.Shaman, RaceName.Troll, RaceFaction.Horde)
            };
        }

        public SelectorController()
        {
            Races.AddRange(this.GetAlliance());
            Races.AddRange(this.GetHorde());
        }

        public Race GetRandomRace()
        {
            return Races[this.RandomIndex];
        }
    }
}