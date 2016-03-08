using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_shit
{
    class Circle : Shape
    {
        public double radius;

        public override string Name { get; set; }

        public override double Area()
        {
            Console.Write("Radius={0}", radius);
            return 3.14159265359 * (radius*radius);
        }

        public override double Circumference()
        {
            return (2 * 3.14159265359) * radius;
        }
    }
}
