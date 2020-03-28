using System;

namespace Quiz_05_Roxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is roxanna's Quiz 05!");
            string test = "I will either find a way or make one";
            Console.WriteLine($"The test string is [{test}].");
            string[] testarray = test.Split(''); 

            int[] myArray =  { 11, 22, 33, 44 };
            Console.WriteLine(myArray[2]);
            double[] yourArray = { (1+Math.Sqrt(500/2)), Math.E, Math.PI, 4.4 };
            Console.WriteLine(yourArray[2]);
            object[] hisArray = { };
            foreach (int e in myArray) // foreach loop is a shortcut, you give it a value of the reference rather than the reference. foreach loop is a a readonly because you have to change the valyue 
            Console.WriteLine(e); // e is the value that it points too  
            
            for (int i = 0; i < myArray.Length; i++) // for loop is difference than foreach b/c you give it a reference and it automatically follows the reference 
            {
                myArray[i] *= 3;
                Console.WriteLine(myArray[i]);
            }
              //  Console.WriteLine(myArray[i]); // this contains a amemory address 
            myArray[2] = 5;
            foreach (int e in myArray) // foreach loop is a shortcut, you give it a value of the reference rather than the reference. foreach loop is a a readonly because you have to change the value 
                Console.WriteLine(e);
            int[] theirArray = myArray;
            foreach (int e in theirArray)
                Console.WriteLine(e);
            // deep copy
            int[] ourArray = new int[myArray.Length];
            for (int i = 0; 1 < ourArray.Length; i++)
                ourArray[i] = myArray[i];
            foreach (int e in ourArray)
                Console.WriteLine(e);
            // flattening an array 
            int[,] ajArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            foreach (int e in ajArray)
                Console.WriteLine(e);
            int[] ccArray = new int[9];
            for (int i = 0);
        }
    }
}
