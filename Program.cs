using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            for (int i = 1; i <= 10; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(i);
            }
            for (int i = 10; i > 0; i--)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
