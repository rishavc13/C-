using System;

namespace MonkAndWelcome
{
    class Program
    {
        static void Main(string[]args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            string[] arr1=Console.ReadLine().Split();
            string[] arr2=Console.ReadLine().Split();
            int[] array1=new int[n];
            int[] array2=new int[n];
            int[] sum=new int[n];
            for(int i=0;i<n;i++)
            {
                array1[i]=int.Parse(arr1[i]);
                array2[i]=int.Parse(arr2[i]);
                sum[i]=array1[i] + array2[i];
                Console.Write(sum[i]+" ");
            }
        }   
    }
}    