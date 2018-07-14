using System;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            int factors,m;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=n;i++)
            {
                factors = 0;
                for(int j=2;j<=i;j++)
                {
                    if(i%j==0)
                    {
                        factors++;
                    }
                }
                if(factors<2)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
