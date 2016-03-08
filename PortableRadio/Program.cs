using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            bool loop = true;
            string menu = "1. Press power button\n2. Change frequency\n3. Change volume";
            int input;

            do
            {
                if (radio.Power == false)
                    Console.WriteLine("Power Off");
                else
                    Console.WriteLine("Power On");
                Console.WriteLine("Frequency: {0:f1}",radio.Frequency);
                Console.WriteLine("Volume: {0}",radio.Volume);
                Console.WriteLine();
                Console.WriteLine(menu);
                input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1:
                        {
                            if (radio.Power == false)
                                radio.Power = true;
                            else
                                radio.Power = false;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Set frequency 2000.0 - 26000.0: ");
                            radio.Frequency = double.Parse(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Set volume 0 - 9 : ");
                            radio.Volume = int.Parse(Console.ReadLine());
                            break;
                        }
                }

            } while (loop == true);
        }
    }
}
