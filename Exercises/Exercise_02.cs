using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
          
            FibonacciNumbers(10);


        }

        private static int GetSum(int start, int end, int sum)
        {
            Console.WriteLine($"The sum is {sum}");
            start++;
            sum += start;
            if (start < end)
            {
                return GetSum(start, end, sum);

            }
            else
            {
                return sum;
            }
        }

        public static String LetterGrade(double grade)     
        {
            String a = "A";
            String b = "B";
            String c = "C";
            String d = "D";
            String f = "F";
            if (grade <= 100 && grade >= 90)
            {
                return a;
            }
            else if (grade < 90 && grade >= 80)
            {
                return b;
            }
            else if (grade < 80 && grade >= 70)
            {
                return c;
            }
            else if (grade < 70 && grade >= 60)
            {
                return d;
            }
            else if (grade < 60)
            {
                return f;
            }
            else
            {
                return ("Invalid input.");
            }
        }

        public static void AvgTenTestScores() 
        {
            string a, b, c, d, e, f, g, h, i, j;

            Console.WriteLine("1st Test Score: ");
            a = Console.ReadLine();
            Console.WriteLine("2nd Test Score: ");
            b = Console.ReadLine();
            Console.WriteLine("3rd Test Score: ");
            c = Console.ReadLine();
            Console.WriteLine("4th Test Score: ");
            d = Console.ReadLine();
            Console.WriteLine("5th Test Score: ");
            e = Console.ReadLine();
            Console.WriteLine("6th Test Score: ");
            f = Console.ReadLine();
            Console.WriteLine("7th Test Score: ");
            g = Console.ReadLine();
            Console.WriteLine("8th Test Score: ");
            h = Console.ReadLine();
            Console.WriteLine("9th Test Score: ");
            i = Console.ReadLine();
            Console.WriteLine("10th Test Score: ");
            j = Console.ReadLine();

            double avgTestScore = ((Convert.ToDouble(a) +
                  Convert.ToDouble(b) +
                  Convert.ToDouble(c) +
                  Convert.ToDouble(d) +
                  Convert.ToDouble(e) +
                  Convert.ToDouble(f) +
                  Convert.ToDouble(g) +
                  Convert.ToDouble(h) +
                  Convert.ToDouble(i) +
                  Convert.ToDouble(j)) / 10.0);
            Console.WriteLine($"Average test score is {LetterGrade(avgTestScore)}");
        }
        static void AvgSpecNumbOfScores() 
        {
            Console.WriteLine("Enter the amount of test scores you want to input: ");
            string testAmount = Console.ReadLine();
            int tests = int.Parse(testAmount);
            double currValue;
            double sum = 0;
            double average = 0;
            for (int i = 0; i < tests; i++)
            {
                Console.WriteLine($"Enter a test score: ");
                string str = Console.ReadLine();
                currValue = double.Parse(str);
                sum = currValue + sum;
                average = sum / tests;
            }
            Console.WriteLine($"Your average test score is {average}, which is an average grade of {LetterGrade(average)}");
        }
        static void AvgNonSpecNumOfTestScores() 
        {
            double input = -1;
            double currValue = -1;
            double sum = 0;
            double average;
            while (currValue != 0)
            {
                Console.WriteLine($"Enter a test score: ");
                Console.WriteLine($"Press enter to input another test score.  Input 0 to show results and exit.");
                string str = Console.ReadLine();
                currValue = double.Parse(str);
                sum = currValue + sum;
                input++;
                if (currValue == 0)
                {
                    average = sum / input;
                    Console.WriteLine($"Your average test score is {average}, which is an average grade of {LetterGrade(average)}");
                }
            }


        }

        public static int FibonacciNumbers(int n) 
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int fib = (n - 2);
                int fib2 = (n - 1);
                int fib3 = fib + fib2;
                Console.WriteLine($"{fib} + {fib2} = {fib3}");
                return FibonacciNumbers(fib + fib2);
            }
        }
    }
}
