using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Convert.ToInt16(Console.ReadLine());
            while(testcases!=0)
            {
                string[] tokens = Console.ReadLine().Split();
                int n = int.Parse(tokens[0]);
                int k = int.Parse(tokens[1]);
                string[] values = Console.ReadLine().Split();
                int[] arr = new int[n];
                for(int i=0;i<n;i++)
                {
                    arr[i] = int.Parse(values[i]);
                }
                List<int> popularity = new List<int>(n);
                foreach (int i in arr)
                {
                    popularity.Add(i);
                }
                while(k>0)
                {
                    bool deleteNode = false;
                    int index;
                    for(index=0; index<popularity.Count-1; index++)
                    {
                        if(popularity[index]< popularity[index+1])
                        {
                            popularity.RemoveAt(index);
                            k--;
                            deleteNode = true;
                        }
                        if(deleteNode==true)
                        {
                            break;
                        }
                    }
                    if(deleteNode==false)
                    {
                        popularity.RemoveAt(popularity[index]);
                        k--;
                    }
                }
                for( int j=0; j<popularity.Count; j++)
                {
                    Console.Write(popularity[j] + " ");
                }
                Console.WriteLine();
                testcases--;
            }
        }
    }
}