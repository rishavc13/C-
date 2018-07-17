using System;

namespace Signal
{
	class Program
	{
		static void Main(string[] args)
		{
			int t=Convert.ToInt16(Console.ReadLine());
			while(t!=0)
			{
				int n=Convert.ToInt16(Console.ReadLine());
				string[] tokens=Console.ReadLine().Split();
				int[] arr= new int[n]; 
				int[] output=new int[n];
				int count;
				for( int i=0;i<n;i++)
				{
					arr[i]=int.Parse(tokens[i]);
				}
				for(int j=n-1; j>=0; j++)
				{
					count=1;
					for(int k=j-1; k>=0; k++)
					{
						if(k<=j)
						{
							count++;
						}
					}
					output[j]=count;
				}
				for(i=0;i<n;i++)
				{
					Console.Write(output[i]+" ");
				}
				t--;
			}
		}
	}
}