using System;

namespace Laddus
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Convert.ToInt16(Console.ReadLine());
            while(testcases!=0)
            {
                int n = Convert.ToInt16(Console.ReadLine());
                string[] tokens = Console.ReadLine().Split();
                int[] arr = new int[n];
                int[] frequency = new int[n];
                int[] output = new int[n];
                int count,max,index=0;
                for(int i=0;i<n;i++)
                {
                    arr[i] = int.Parse(tokens[i]);
                }
                for(int j=0;j<n;j++)
                {
                    count = 0;
                    for(int k=0;k<n;k++)
                    {
                        if(arr[k]==arr[j])
                        {
                            count++;
                        }
                    }
                    frequency[j] = count;
                }
                for(int i=0;i<n;i++)
                {
                    max = frequency[i];
                    for(int j=i+1;j<n;j++)
                    {
                        if(frequency[j]>max)
                        {
                            max = frequency[j];
                            index = j;
                            break;
                        }
                    }
                    if(max>frequency[i])
                    {
                        output[i] = arr[index];
                    }
                    else
                    {
                        output[i] = -1;
                    }
                }
                for(int i=0;i<n;i++)
                {
                    Console.Write(output[i] + " ");
                }
                Console.WriteLine();
                testcases--;
            }
            Console.ReadLine();
        }
    }
}
