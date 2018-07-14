using System;

namespace CountDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
			string[] tokens= Console.ReadLine().Split();
			int left=int.Parse(token[0]);
			int right=int.Parse(token[1]);
			int key=int.Parse(token[2]);
			for(int i=left;i<=right;i++)
			{
				if(i%key==0)
				{
					count++;
				}
			}
			Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
