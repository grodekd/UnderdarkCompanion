using System.Collections.Generic;

namespace UnderdarkCompanion
{
    public static class LocationDictionary
    {
        private static Dictionary<string, Dictionary<string, int>> locationLookup = new Dictionary<string, Dictionary<string, int>>
        {
            {"Velkynvelve", new Dictionary<string, int>{
                { "Sloobludop", 48},
                { "Gracklstugh", 168 },
                { "Neverlight Grove", 216 },
                { "Blingdenstone", 180 },
                { "Menzoberranzan", 156 }
            }},
            {"Sloobludop", new Dictionary<string, int>{
                { "Velkynvelve", 48},
                { "Gracklstugh", 120 },
                { "Neverlight Grove", 156 },
                { "Blingdenstone", 120 },
                { "Menzoberranzan", 120 }
            }},
            {"Gracklstugh", new Dictionary<string, int>{
                { "Velkynvelve", 168},
                { "Sloobludop", 120 },
                { "Neverlight Grove", 72 },
                { "Blingdenstone", 120 },
                { "Menzoberranzan", 162 }
            }},
            {"Neverlight Grove", new Dictionary<string, int>{
                { "Velkynvelve", 216},
                { "Sloobludop", 156 },
                { "Gracklstugh", 72 },
                { "Blingdenstone", 96 },
                { "Menzoberranzan", 144 }
            }},
            {"Blingdenstone", new Dictionary<string, int>{
                { "Velkynvelve", 180},
                { "Sloobludop", 120 },
                { "Gracklstugh", 120 },
                { "Neverlight Grove", 96 },
                { "Menzoberranzan", 48 }
            }},
            {"Menzoberranzan", new Dictionary<string, int>{
                { "Velkynvelve", 156},
                { "Sloobludop", 120 },
                { "Gracklstugh", 162 },
                { "Neverlight Grove", 144 },
                { "Blingdenstone", 48 }
            }}
        };

        public static List<string> GetLocationNames()
        {
            var names = new List<string>(locationLookup.Keys);
            names.Add("???");
            return names;
        }

        public static int GetMilesBetween(string outsetName, string destinationName)
        {
            return destinationName == "???" ? 0 : locationLookup[outsetName][destinationName];
        }
    }
}
