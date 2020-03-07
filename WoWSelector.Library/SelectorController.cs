using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using WoWSelector.Library.Races;

namespace WoWSelector.Library
{
    public class SelectorController
    {
        private readonly List<Race> Races = new List<Race>();

        private readonly Random _random = new Random();

        private int RandomIndex => _random.Next(0, Races.Count - 1);

        public SelectorController()
        {
            // get the assembly path
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Races", "RacesConfig.json");

            // load config
            using (var stream = File.OpenText(path))
            {
                var serializer = new JsonSerializer();
                this.Races = (List<Race>)serializer.Deserialize(stream, typeof(List<Race>));
            }
        }

        public Race GetRandomRace()
        {
            return Races[this.RandomIndex];
        }
    }
}