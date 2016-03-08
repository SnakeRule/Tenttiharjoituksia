using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public static class Arraycalcs
    {
        static public double Sum (double[] array)
        {
            return array.Sum();
        }

        static public double Average (double[] array)
        {
            return array.Average();
        }

        static public double Min (double[] array)
        {
            return array.Min();
        }

        static public double Max (double[] array)
        {
            return array.Max();
        }
    }
}
