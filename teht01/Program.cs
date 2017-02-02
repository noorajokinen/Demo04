using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Elevator elevator = new Elevator();
            Console.WriteLine("Current floor is > " + elevator.Floor);

            do
            {
                Console.Write("Give a floornumber > ");
                string line = Console.ReadLine();
                elevator.Floor = int.Parse(line);
                Console.WriteLine("Current floor is > " + elevator.Floor);
            }
            while (true);
        }
    }
}
