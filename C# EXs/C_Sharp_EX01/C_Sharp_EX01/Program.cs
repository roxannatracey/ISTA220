using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1: Find the circumference and area of a circle 

            Console.WriteLine("Circumference and area for a circle");

            Console.WriteLine("Enter an integer for the radius for Circumference");
            string str_var = Console.ReadLine();
            int int_var = int.Parse(str_var);
            double CircleRadius = int_var;
            double PI = Math.PI;
            double CircleCircumference = (2 * Math.PI * CircleRadius);
            Console.WriteLine("Circumference of the circle " + CircleCircumference);

            Console.WriteLine("Enter an integer for the radius for Area");
            str_var = Console.ReadLine();
            int_var = int.Parse(str_var);
            double CircleArea = (PI * (CircleRadius * CircleRadius));

            Console.WriteLine("Area of a circle " + CircleArea);


            // part 2 Find the volume of hemisphere

            Console.WriteLine("Volume of a hemisphere");
       
            str_var = Console.ReadLine();
            int int_var_hemi = int.Parse(str_var);
            double Hemi_Rad = int_var_hemi;
            double Hemi_Vol = ((4 / 3) * Math.PI * (Hemi_Rad * Hemi_Rad * Hemi_Rad)) /2;
            Console.WriteLine("Volume of the hemisphere " + Hemi_Vol);

            // part 3 finding the area of a tirangle given the length of the sides

            Console.WriteLine("Area of a triangle");

            Console.WriteLine("Enter side A");
            str_var = Console.ReadLine();
            int sideA = int.Parse(str_var);

            Console.WriteLine("Enter side B");
            str_var = Console.ReadLine();  
            int sideB = int.Parse(str_var);

            Console.WriteLine("Enter side C");
            str_var = Console.ReadLine();
            int sideC = int.Parse(str_var);

            int peri = (( sideA + sideB + sideC) / 2);
            double TriArea = Math.Sqrt((peri * (peri - sideA) * (peri - sideB) *(peri - sideC))/ 2);
            Console.WriteLine("area of a triangle " + TriArea);

            // part 4 solving a quadratic equation 

            Console.WriteLine(" solving a quadratic equation");

            // variables i'm claiming 

            Console.WriteLine("Enter variable for A");
            str_var = Console.ReadLine();
            double int_A = double.Parse(str_var);
            
            Console.WriteLine("Enter variable for B");
            str_var = Console.ReadLine();
            double int_B = double.Parse(str_var);

            Console.WriteLine("Enter variable for C");
            str_var = Console.ReadLine();
            double int_C = double.Parse(str_var);

            double quadX = (-int_B) + ((Math.Sqrt(int_B * int_B) - (4 * int_A * int_C) / (2 * int_A)));
            double quadY = (-int_B) - ((Math.Sqrt(int_B * int_B) - (4 * int_A * int_C) / (2 * int_A)));
            Console.WriteLine("postive quadratic formula: " + quadX);
            Console.WriteLine("negative quadratic formula " + quadY);
        }
    }
}
