using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRadio
{
    class Radio
    {
        private bool power;
        private int volume;
        private double frequency;

        public bool Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value == true)
                {
                    power = true;
                }
                else power = false;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (power == true)
                {
                    if (value >= 0 && value < 10)
                    {
                        volume = value;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("You can't set the volume below 0! - volume set to 0");
                        volume = 0;
                    }
                    else if (value > 9)
                    {
                        Console.WriteLine("You can't set the volume above 9! - volume set to 9");
                        volume = 9;
                    }
                }
                else
                    Console.WriteLine("The radio is not on!");
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (power == true)
                {
                    if (value >= 2000.0 && value <= 26000.0)
                    {
                        frequency = value;
                    }
                    else if (value < 2000.0)
                    {
                        Console.WriteLine("Can't set frequency below 2000,0! - Frequency set to 2000,0");
                        frequency = 2000.0;
                    }
                    else if (value > 26000.0)
                    {
                        Console.WriteLine("Can't set frequency above 26000,0! - Frequency set to 26000,0");
                        frequency = 26000.0;
                    }
                }
                else
                    Console.WriteLine("The radio is not on!");
            }
        }

        public Radio()
        {
            power = false;
            volume = 0;
            frequency = 2000.0;
        }
    }
}
