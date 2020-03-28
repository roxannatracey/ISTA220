using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Rifles : Weapon
    {
        public int SizeOfScope { get; set; }


        public override void PrintMe()
        {
            Console.WriteLine("The rifle damage level {0}", this.Damage);
            Console.WriteLine("{0} - {1}", this.RoundSize, this.SizeOfScope);
        }
        public override void shoot()
        {
            Console.WriteLine(" gratata gratata");
        }
    }



}