using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
           Point origin = new Point(); // point is the type, origin is the name/variable = is the assignment operator and new goes to the heap 
            //and allocates sufficent amount of memory to hold and object of that type and returns it to the stack 
            // origin contains the memory address which points to a space in the heap 
            // Point(); is a constructor  
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point maxwell = new Point(1, 1);
            Point christy = new Point(4, 5);
            distance = maxwell.DistanceTo(christy); // preiod(.) access operator gives you access to the fields in a method. 
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        // contains a memory address 
    }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
