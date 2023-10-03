using System.Runtime.InteropServices;

namespace Test2
{
    internal class Program
    {
        static void Main()
        {
            int s = 0;
            do
            {
                Console.WriteLine("Choose a minigame");
                Console.WriteLine("1. Guess the number");
                Console.WriteLine("2. Multiplication table");
                Console.WriteLine("3. Number Divisors");
                Console.WriteLine("4. Exit");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    GuessTheNumber();
                }
                if (s == 2)
                {
                    MultiplicationTable();
                }
                if (s == 3)
                {
                    NumberDivisors();
                }
            }
            while (s != 4);
        }

        static void GuessTheNumber()
        {
            int g = 0;
            int h = 0;
            do
            {
                g = 0;
                Console.WriteLine("Guess The Number, do you want to play?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                g = Convert.ToInt32(Console.ReadLine());
                if (g == 1)
                {
                    Random rnd = new Random();
                    var Number = rnd.Next(101);
                    Console.WriteLine("Type in a number from 0 to 100");
                    while (h != Number)
                    {
                        h = Convert.ToInt32(Console.ReadLine());
                        if (h == Number)
                        {
                            Console.WriteLine(Number + " Thats right!");
                        }
                        if (h > Number)
                        {
                            Console.WriteLine("Less");
                        }
                        if (h < Number)
                        {
                            Console.WriteLine("More");
                        }
                    }
                }
            }
            while (g != 2);
        }
        static void MultiplicationTable()
        {
            int[,] MTable = new int[10, 10];
            int v = 1;
            int n = 1;
            for (int i = 0; i < 10; i++)
            {
                v = 1;
                for (int j = 0; j < 10; j++)
                {
                    MTable[i, j] = v * n;
                    v++;
                }
                n++;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,4}", MTable[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void NumberDivisors()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine("Type in a number");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a+1; i++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                    b++;
                }
                else
                {
                    b++;
                }
            }
        }
    }
}