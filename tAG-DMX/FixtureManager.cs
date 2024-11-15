using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tAG_DMX
{
    internal class FixtureManager
    {
        private static readonly string FixturesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fixtures");

        public static void SaveFixture(Fixture fixture)
        {
            if (!Directory.Exists(FixturesDirectory))
            {
                Directory.CreateDirectory(FixturesDirectory);
            }

            string filePath = Path.Combine(FixturesDirectory, $"{fixture.Model}.json");
            string json = JsonSerializer.Serialize(fixture, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Fixture> LoadFixtures()
        {
            var fixtures = new List<Fixture>();

            if (Directory.Exists(FixturesDirectory))
            {
                foreach (var file in Directory.GetFiles(FixturesDirectory, "*.json"))
                {
                    string json = File.ReadAllText(file);
                    var fixture = JsonSerializer.Deserialize<Fixture>(json);
                    if (fixture != null)
                    {
                        fixtures.Add(fixture);
                    }
                }
            }

            return fixtures;
        }
    }
}
