using System;

namespace FacebookProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt16(Console.ReadLine());
            while(n!=0)
            {
                string[] dim = Console.ReadLine().Split();
                int width = int.Parse(dim[0]);
                int height = int.Parse(dim[1]);
                if(width<l || height<l)
                    Console.WriteLine("UPLOAD ANOTHER");
                else
                {
                    if(width==height)
                        Console.WriteLine("ACCEPTED");
                    else
                        Console.WriteLine("CROP IT");
                }
                n--;
            }
            Console.ReadLine();
        }
    }
}
