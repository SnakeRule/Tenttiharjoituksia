using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double dblnumber;
            int intnumber;

            StreamWriter ints = new StreamWriter("ints.txt");
            StreamWriter doubles = new StreamWriter("doubles.txt");

            do
            {
                Console.WriteLine("Give a number (Enter or not a number ends) : ");
                input = Console.ReadLine();

                if (int.TryParse(input, out intnumber) == true)
                {
                    ints.WriteLine(intnumber);
                }
                else if (double.TryParse(input, out dblnumber) == true)
                {
                    doubles.WriteLine(dblnumber);
                }
                else input = null;

            } while (input != null);

            ints.Close();
            doubles.Close();
        }
    }
}
