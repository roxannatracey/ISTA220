
using System;

namespace parameter_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling ordinary array");
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum1 = method1(array1);
            Console.WriteLine($"sum 1 is {sum1}");
            int sum2 = method2(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"sum 2 is {sum2}");
        }

        private static int method1(int[] array1)
        {
            int sum = 0;
            foreach (int i in array1)
            {
                sum += i;
            }
            return sum;
        }

        private static int method2(params int[] array1)
        {
            int sum = 0;
            foreach (int i in array1)
            {
                sum += 1;
            }
            return sum;
        }
    }
}
