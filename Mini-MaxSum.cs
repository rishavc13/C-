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
    static void miniMaxSum(int[] arr) 
	{
        Array.Sort(arr);
        long min=(long)(arr[0]+arr[1]+arr[2]+arr[3]);
        long max=(long)(arr[1]+arr[2]+arr[3]+arr[4]);
        Console.WriteLine("{0} {1}",min,max);
    }

    static void Main(string[] args)
	{
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        miniMaxSum(arr);
    }
}
