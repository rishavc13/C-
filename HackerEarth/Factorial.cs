using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for(int i=1;i<=number;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
