using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicles
    {
        public int ArmorLevel { get; set; }
        public int NumOfWheels { get; set; }
        public int NumOfSeats { get; set; }

        public virtual void PrintMe()
        {
            Console.WriteLine("{0} - {1}", ArmorLevel, NumOfWheels);
        }

        public virtual void start()
        {
            Console.WriteLine("The Vehicle is starting");

        }
    }
}