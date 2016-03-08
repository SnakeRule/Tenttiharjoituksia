using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_shit
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle smallCircle = new Circle { Name = "Circle", radius = 1.5 };
            Circle mediumCircle = new Circle { Name = "Circle", radius = 3 };
            Circle largeCircle = new Circle { Name = "Circle", radius = 6.5 };
            Rectangle smallRectangle = new Rectangle { Name = "Rectangle", Width = 1.5, Height = 0.5 };
            Rectangle mediumRectangle = new Rectangle { Name = "Rectangle", Width = 4.5, Height = 2.5 };
            Rectangle largeRectangle = new Rectangle { Name = "Rectangle", Width = 7, Height = 5 };
            Shapes shapes = new Shapes();

            shapes.addCircle(smallCircle);
            shapes.addCircle(mediumCircle);
            shapes.addCircle(largeCircle);
            shapes.addRectangle(smallRectangle);
            shapes.addRectangle(mediumRectangle);
            shapes.addRectangle(largeRectangle);

            shapes.showShapes();
        }
    }
}
