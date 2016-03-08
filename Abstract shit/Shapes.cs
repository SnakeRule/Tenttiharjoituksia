using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_shit
{
    class Shapes
    {
        List<object> shapes;

        public Shapes()
        {
            shapes = new List<object>();
        }

        public void addCircle(Circle circle)
        {
            shapes.Add(circle);
        }

        public void addRectangle(Rectangle rectangle)
        {
            shapes.Add(rectangle);
        }

        public void showShapes()
        {
            foreach(Shape shape in shapes)
            {
                Console.WriteLine("{0} Area={1} Circumference{2}" ,shape.Name, shape.Area(), shape.Circumference());
            }
        }
    }
}
