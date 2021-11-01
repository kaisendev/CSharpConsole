using System;
using System.Collections.Generic;
using System.Linq;

namespace Hobbies
{
    public class HobbyistStore
    {
        public Dictionary<string, string[]> Hobbyists { get; set; }

        public void Add(string name, params string[] hobbies)
        {
            if(Hobbyists == null)
            {
                Hobbyists = new Dictionary<string, string[]>();
            }

            Hobbyists.Add(name, hobbies);
        }

        public List<string> FindHobbyist(string hobby)
        {
            var hobbyistNames = new List<string>();

            foreach(var pair in Hobbyists)
            {
                if (pair.Value.Any(v => v.Equals(hobby, StringComparison.OrdinalIgnoreCase)))
                {
                    hobbyistNames.Add(pair.Key);
                }
            }

            return hobbyistNames;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var store = new HobbyistStore();
            store.Add("Blink", "Gym", "Games");
            store.Add("Prize", "Sleep", "Strip Club");
            store.Add("Joms", "Gym", "Eat", "Jump Rope");

            var hobbyistNames = store.FindHobbyist("Jump Rope");

            foreach (var name in hobbyistNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
