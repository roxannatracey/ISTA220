#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Quiz_0445
{
    public class Firearm
    {
        string name;
        string sound;
        public Firearm(string name, string sound)
        {
            Console.WriteLine($"I am a {name} and I go {sound}");
        }
    }

    class program
    {
        static void Main() // main method 
        {
            Firearm firearm1 = new Firearm("Shotgun", "boom");
            //Declare new firearm - rifle 

            Firearm firearm2 = new Firearm("Rifle", "Bang");

            //declare new firearm - pistol 
            Firearm firearm3 = new Firearm("Pistol", "Pop");


        }

    }

}

