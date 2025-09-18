using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Arrays
    {
        public bool error = false;
        int[] temperature;
        int[] precipitation;
        int length = 10;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int this[int i]
        {
            get
            {
                if (0 <= i && i < length) { return temperature[i]; }
                else { error = true; return 0; }
            }

            set
            {
                if (0 <= i && i < length && value >= -50 && value <= 50) { temperature[i] = value; }
                else { error = true; }
            }
        }

        public Arrays()
        {
            temperature = new int[length];
            precipitation = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                temperature[i] = rand.Next(-10, 20);
                precipitation[i] = rand.Next(0, 2); 
            }
        }

        public (int, int) PrecipitationSum
        {
            get
            {
                int rain = 0, snow = 0;
                for (int i = 0; i < length; i++)
                {
                    if (temperature[i] > 0)
                        rain += precipitation[i];
                    else
                        snow += precipitation[i];
                }
                return (rain, snow);
            }
        }

        public int[] GetPrecipitations() => precipitation;
        public int[] GetTemperatures() => temperature;
    }
}