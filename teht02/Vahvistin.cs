using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Vahvistin
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 100;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > maxVolume) 
                {
                    Console.WriteLine("Too much volume - Amplifier volume is se to maximum:100");
                    volume = maxVolume;
                }
                if (value < minVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is se to minimum:0");
                    volume = minVolume;
                }

                else volume = value;
            }
        }
        public void DeafultVolume()
        {
            volume = 0;
        }
    }
}
