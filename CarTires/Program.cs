using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTires
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle audiA3 = new Vehicle { Name = "Audi A3" };
            Tyre tyre1 = new Tyre { TyreName = "Bridgestone 205/55R16" };

            audiA3.addTyre(tyre1);
            audiA3.addTyre(tyre1);
            audiA3.addTyre(tyre1);
            audiA3.addTyre(tyre1);

            audiA3.showInfo();

            Vehicle kawasakiNinja = new Vehicle { Name = "Kawasaki Ninja" };
            Tyre tyre2 = new Tyre { TyreName = "I dunno, some motorcycle tyre?" };

            kawasakiNinja.addTyre(tyre2);
            kawasakiNinja.addTyre(tyre2);

            kawasakiNinja.showInfo();
        }
    }
}
