using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
           
            {
                int x = 1;
                do
                {
                    x += 10;
                } while (false);
                return x; // What is x?
            }
            {
                int i;
                for (i = 0; i < 10; i++) { }
                int x = i;
                return x; // What is x?
            }
        }
    }
}
