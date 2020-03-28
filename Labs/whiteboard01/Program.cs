using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can also use a string instead of a array
            // im also sure theres a way to do it in one method
            char[] array1 = new char[] { 'M', 'i', 's', 's', 'i', 's', 's', 'i', 'p', 'p', 'i' };
            M(array1);
            I(array1);
            s(array1);
            p(array1);
        }

        private static void I(char[] array1)
        {
            int count = 0;
            char charToCount = 'i';
            foreach (char i in array1)
            {
                if (i == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} letter I in Mississippi");
        }
        private static void p(char[] array1)
        {
            int count = 0;
            char charToCount = 'p';
            foreach (char p in array1)
            {
                if (p == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} letter p in Mississippi");
        }
        private static void s(char[] array1)
        {
            int count = 0;
            char charToCount = 's';
            foreach (char s in array1)
            {
                if (s == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} letter s in Mississippi");
        }
        private static void M(char[] array1)
        {
            int count = 0;
            char charToCount = 'M';
            foreach (char M in array1)
            {
                if (M == charToCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"There is {count} letter M in Mississippi");
        }
    }
}

