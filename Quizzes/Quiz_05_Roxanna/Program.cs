using System;

namespace Quiz_05_Roxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is roxanna's Quiz 05!");
            string data = "I think therefore I am"; // this is the input string 
            Console.WriteLine($"The test string is [{data}].");
            // not sure what to put here 
         
            int[] myArray = { 4, 3, 2, 1, 0};
            Console.WriteLine($"The length of my array is 5.");
            string[] theArray = myArray.Split(' ');

            string[] words = data.Split(' '); // this will separate all the words 
            foreach (string word in words)
            {
                Console.WriteLine("[{myArray}]" + word);
            }
        }
    }
}
