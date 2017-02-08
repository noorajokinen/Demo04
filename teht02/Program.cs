using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();
            Console.WriteLine("- Amplifier volume is now: " + vahvistin.Volume);

            do
            {
                Console.Write("Give a new volume value (0-100) > ");
                string line = Console.ReadLine();
                vahvistin.Volume = int.Parse(line);
                Console.WriteLine("- Amplifier volume is now: " + vahvistin.Volume);
            }
            while (true);
        }
    }
}
