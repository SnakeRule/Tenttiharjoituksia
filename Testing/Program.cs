using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            result = Arraycalcs.Sum(array);
            Console.WriteLine("Sum = {0}", result);

            result = Arraycalcs.Average(array);
            Console.WriteLine("Average = {0}", result);

            result = Arraycalcs.Min(array);
            Console.WriteLine("Min = {0}", result);

            result = Arraycalcs.Max(array);
            Console.WriteLine("Max = {0}", result);
        }
    }
}
