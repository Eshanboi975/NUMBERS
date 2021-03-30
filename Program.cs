using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to see: ")
            
            int count = Convert.ToInt32(Console.ReadLine());    
                
            Console.WindowHeight = 40;
            for (int i = 1; i <= 10; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            for (int i = 10; i > 0; i--)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
