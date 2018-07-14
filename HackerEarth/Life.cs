using System;

namespace Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine()) ;
            while(number!=42)
            {
                Console.WriteLine(number);
                number = Convert.ToInt16(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
