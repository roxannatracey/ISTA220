#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 69; //declares an integer type of value named i and assigns it 0 
            Console.WriteLine(i); 
            Pass.Value(i); // calls the method from the pass class which sets the parameter to 42 
            Console.WriteLine(i); // will print parameter 69
            // this executes 69 because it passed a value and not a reference 
            Console.WriteLine("-----------------");
            WrappedInt wi = new WrappedInt(); // creates a new instance 
            Console.WriteLine(wi.Number); // writes the value of the wrappedint 
            Pass.Reference(wi); // it references the pass object to get the  value
            Console.WriteLine(wi.Number); // this references the memory address so it goes to the heap and changes the value on the heap 
            Console.WriteLine("-----------------");
            int j = 1776;
            Console.WriteLine(j);
            Pass.Value(ref j); // passing j (value type) by reference 
            Console.WriteLine(j);

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
