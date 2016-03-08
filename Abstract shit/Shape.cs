using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_shit
{
    abstract class Shape
    {
        public abstract string Name { get; set; }

        public abstract double Area();

        public abstract double Circumference();
    }
}
