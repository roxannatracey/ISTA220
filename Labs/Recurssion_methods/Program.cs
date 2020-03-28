using System;

namespace Recurssive_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Print number from 0 to 10");
            int start = 0;
            printNumbers(start);
            Console.WriteLine("Finished Print Number, hit any key");
            Console.ReadKey();

            Console.WriteLine("Print number from 0 to 10");
            int i = 0;
            int sum = 0;
            sum = addNumbers(sum, i);
            printNumbers(sum);
            Console.WriteLine("Finished Print Number, hit any key");
            Console.ReadKey();

            Console.WriteLine("Multiply number from 0 to 10");
            int j = 1;
            int product = 1;
            sum = MultiplyNumbers(product, j);
            printNumbers(sum);
            Console.WriteLine("Finished Print Number, hit any key");
            Console.ReadKey();

            Console.WriteLine("add squarenumber from 0 to 10");
            int k = 1;
            int sumSquare = 1;
            sum = MultiplySquares(sumSquare, k);
            printNumbers(sum);
            Console.WriteLine("Finished Print Number, hit any key");
            Console.ReadKey();
            // quiz 4.5 
            Console.WriteLine("add the square roots from 0 to 10");
            double r = 0;
            double sumroots = 0;
            sumroots =  AddRoots(sumroots, r);
            printNumbers(sum);
            Console.WriteLine($"Sum roots is {sumroots}, hit any key");
            Console.ReadKey();

        }
        private static double AddRoots(double sumroots, double r)
        {
            if (r > 10)
                return sumroots;
            else
            {
                return AddRoots(sumroots + Math.Sqrt(r), r + 1);
            }
        }

        private static int MultiplySquares(int sumSquare, int k)
        {
            if (k > 10)
                return sumSquare;
            else
                return MultiplySquares(sumSquare + (k * k), k + 1);


        }
        private static int MultiplyNumbers(int product, int j)
        {

            if (j > 6)
                return product;
            else
                return MultiplyNumbers(product * j, j + 1);
        }

        private static int addNumbers(int sum, int i)
        {
            if (i > 10)
                return sum;
            else
                return addNumbers(sum + i, i + 1);
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


