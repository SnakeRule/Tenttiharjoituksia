using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fisher
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        private List<Fish> fishes;

        public Fisher()
        {
            fishes = new List<Fish>();
        }

        public void addFish(Fish fish)
        {
            fishes.Add(fish);
        }

        public void showFish()
        {
            fishes.Sort((x, y) => y.Weight.CompareTo(x.Weight));
            Console.WriteLine("The fish have been sorted by weight");

            Console.WriteLine("\nFisher name: {0}\n", Name);

            foreach(Fish fish in fishes)
            {
                Console.WriteLine("The fish is a {0}!", fish.Species);
                Console.WriteLine("It's {0}cm long", fish.Length);
                Console.WriteLine("And it weighs in at {0}kg!", fish.Weight);
                Console.WriteLine("The {0} was caught at {1}, which is in {2}!\n", fish.Species, fish.Place, fish.Location);
            }
        }
    }
}
