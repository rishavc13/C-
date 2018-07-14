using System;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases=Convert.ToInt16(Console.ReadLine());
            while(testcases!=0)
            {
                int n=Convert.ToInt16(Console.ReadLine());
                string[] s=Console.ReadLine().Split();
                int len=s.Length;
                int[] ar=new int[len];
                for(int j=0;j<len;j++)
                {
                    ar[j]=int.Parse(s[j]);
                }
                int max=1;
                for(int i=0;i<len-1;i++)
                {
                    if(ar[i+1]<ar[i])
                    {
                        max++;
                    }
                }
                Console.WriteLine(max);
                testcases--;
            }
        }
    }
}