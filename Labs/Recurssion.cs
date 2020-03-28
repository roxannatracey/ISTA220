using System;

namespace Recurssivemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers from 0 to 10");
            int start = 0; // creates a variable called start initalizes it to 0 
            printNumbers(start); //invokes a method called start 
            Console.WriteLine("Finished print number, hit any key");
            Console.ReadKey();
            // correct 
            Console.WriteLine("Print numbers from 0 to 10");
            int i = 0;
            int sum = 0;
            sum = AddNumbers(sum, i);
            Console.WriteLine("Finished print number, hit any key");
            Console.ReadKey();

            Console.WriteLine("Multiply numbers from 0 to 10");
            int j = 1;
            int product = 1;
            sum = MultiplyNumbers(product, j);
            Console.WriteLine("Finished print number, hit any key");
            Console.ReadKey();

            Console.WriteLine("Add square numbers from 0 to 10");
            int k = 1;
            int sumsquares = 1;
            sumsquares = MultiplySquares(sumSquare, k);
            printNumbers(sum);
            Console.WriteLine("finished print number, hit any key");
            Console.ReadKey();

        }
        private static int MultiplySquares(int sumSquare, int k)
        {
            if (k > 10)
                return sumSquare;
            else
                return Multiplysquares(sumSquare + (k * k), k + 1);
        }

        private static int MultiplyNumbers(int product, int j)
        {
            if (j > 6)
                return product;
            else return MultiplyNumbers(product * j, j + 1); // same * 
        }
        private static int AddNumbers(int sum, int i)
        {
            if (i > 10)
                return sum;
            else
                return AddNumbers(sum + i, i + 1);

        }
        private static void printNumbers(int start)
        {
            Console.WriteLine(start);
            if (start > 10)
                return;
            else
                 printNumbers(start + 1);

        }
    }
}

