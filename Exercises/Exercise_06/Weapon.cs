using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapon
    {
        public Double RoundSize { get; set; }
        public int Damage { get; set; }


        public virtual void PrintMe()
        {
            Console.WriteLine("The rifle damage level {0}", this.Damage);
            Console.WriteLine("{0} - {1}", this.RoundSize, this.Damage);
        }
        public virtual void shoot()
        {
            Console.WriteLine("The weapon is firing");
        }
    }
}