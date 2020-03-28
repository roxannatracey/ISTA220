using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
          //  Console.WriteLine(Util.Sum(null));
          //  Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(Util.Sum(1)); //uses opt.params 
            Console.WriteLine(Util.Sum(10,20));
            Console.WriteLine(Util.Sum(1, 2, 3));
            Console.WriteLine(Util.Sum(1, 2, 3, 4)); //less than 4 uses opt param = more specific
            Console.WriteLine(Util.Sum(1, 2, 3, 4, 5)); 


        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
