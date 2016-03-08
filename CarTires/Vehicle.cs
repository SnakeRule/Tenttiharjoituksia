using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTires
{
    class Vehicle
    {
        public string Name { get; set; }
        List<Tyre> tyres;

        public Vehicle()
        {
            tyres = new List<Tyre>();
        }

        public void addTyre(Tyre tyre)
        {
            tyres.Add(tyre);
        }

        public void showInfo()
        {
            Console.WriteLine("Vehicle Name : {0}", Name);
            Console.WriteLine("Tyres in vehicle: ");
            foreach (Tyre tyre in tyres)
            {
                Console.WriteLine(tyre.TyreName);
            }
        }
    }
}
