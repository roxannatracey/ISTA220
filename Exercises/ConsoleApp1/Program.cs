using System;


namespace Exercise_05_barahona 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine(" Part 0 Print Array");
            printArray(ArrayA);
            printArray(ArrayB);
            printArray(ArrayC);

            Console.WriteLine(" Part 1 Counting, summing, computing Array");
            MeanAndSum(ArrayA);
            MeanAndSum(ArrayB);
            MeanAndSum(ArrayC);

            Console.WriteLine(" Part 2 Reverse Array");
            Console.WriteLine("Reverse Array A.");
            ReverseArray(ArrayA);
            Console.WriteLine("Reverse Array B.");
            ReverseArray(ArrayB);
            Console.WriteLine("Reverse Array C.");
            ReverseArray(ArrayC);

            Console.WriteLine(" Part 3 Rotate Array");
            Console.WriteLine(" rotate array A two places to the left.");
            RotateArray("L", 2, ArrayA);
            Console.WriteLine(" rotate array B two places to the right.");
            RotateArray("R", 2, ArrayB);
            Console.WriteLine(" rotate array c four places to the left.");
            RotateArray("L", 4, ArrayC);
            Console.WriteLine();

            Console.WriteLine("Part 4 Sort Array");
            SortArray(ArrayA);
            SortArray(ArrayB);
            SortArray(ArrayC);
        }
        public static void MeanAndSum(int[] array)
        {
            int sum = 0;

            int len = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i + 1 == len)
                {
                    Console.WriteLine($"sum is: {sum}. The mean is {(double)sum / (double)len}");
                }
            }
        }

        private static void printArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {

            }
            Console.WriteLine(string.Join(" ", arr));
        }
        private static void SortArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {

                Console.WriteLine($" var i is {i}, current element is {arr[i]}");

                for (int j = i + 1; j < len; j++)
                {
                    Console.WriteLine($" var j is {j}, current element is {arr[j]}");
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


            }
            foreach (int e in arr)
                Console.Write($"{e} ");
            Console.WriteLine();
        }
        private static void RotateArray(string direction, int places, int[] arr)
        {

            Console.WriteLine($"direction is {direction}, places = {places}");
            int len = arr.Length;
            if (direction == "R")
            {
                places = len - places;
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{arr[(i + places) % len]}");
            }

        }
        private static void ReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}