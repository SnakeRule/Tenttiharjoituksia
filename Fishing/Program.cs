using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisher elmo = new Fisher { Name = "Elmu elmuli", Phone = "04045645" };
            Fish kissfish = new Fish
            {
                Species = "Kissfish",
                Length = 160,
                Weight = 66.6,
                Place = "Kissing booth",
                Location = "Kissland"
            };
            Fish poopfish = new Fish
            {
                Species = "Poopfish",
                Length = 1,
                Weight = 300,
                Place = "Butt",
                Location = "Booty"
            };

            elmo.addFish(kissfish);
            elmo.addFish(poopfish);

            elmo.showFish();
        }
    }
}
