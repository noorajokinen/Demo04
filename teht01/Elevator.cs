using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Elevator
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;

                else
                {
                    Console.WriteLine("That floor does not exist!");
                }
                
            }
        }

        public void DefaultFloor()
        {
            floor = 1;
        }


      
    }
}
