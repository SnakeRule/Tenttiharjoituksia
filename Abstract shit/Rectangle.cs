using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_shit
{
    class Rectangle : Shape
    {
        public override string Name { get; set; }
        public double Width;
        public double Height;

        public override double Area()
        {
            Console.Write("Width={0} Height={1} ", Width, Height);
            return Width * Height;
        }

        public override double Circumference()
        {
            return 2 * (Height + Width);
        }
    }
}
