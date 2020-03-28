using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M199 : Vehicles
    {
        public int TopSpeed { get; set; }

        public override void PrintMe()
        {
            Console.WriteLine("The armour level is {0}", this.ArmorLevel);
            Console.WriteLine("{0} - {1}", this.ArmorLevel, this.TopSpeed);
        }

    }
}