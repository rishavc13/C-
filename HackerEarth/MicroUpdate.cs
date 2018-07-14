using System;

namespace MicroUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases=Convert.ToInt16(Console.ReadLine());
            while(testcases!=0)
            {
                string[] tokens=Console.ReadLine().Split();
                string[] arr=Console.ReadLine().Split();
                int n=int.Parse(tokens[0]);
                int k=int.Parse(tokens[1]);
                int[] numbers=new int[n];
                for(int i=0;i<n;i++)
                {
                    numbers[i]=int.Parse(arr[i]);
                }
                Array.Sort(numbers);
                int difference=k-numbers[0];
                if(difference<=0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(difference);
                }
                testcases--;
            }
        }
    }
}