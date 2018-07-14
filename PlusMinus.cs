using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution 
{
    static void plusMinus(int[] arr)
	{
		int positive=0,negative=0,zero=0;
        int count=arr.Length;
        foreach(int i in arr)
        {
            if(i>0)
                positive++;
            else if(i<0)
                negative++;
            else
                zero++;
        }
        float pos=(float)positive/count;
        float neg=(float)negative/count;
        float zer=(float)zero/count;
        Console.WriteLine(pos);
        Console.WriteLine(neg);
        Console.WriteLine(zer);

    }

    static void Main(string[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}