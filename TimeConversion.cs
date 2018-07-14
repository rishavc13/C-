using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static string timeConversion(string s)
	{
		string[] ar=s.Split(':');
        string str=ar[2].Substring(2);
        string result=string.Empty;
        int x;
        if(str=="PM")
        {
            if(ar[0]=="12")
            {
                result=string.Concat("12:",ar[1],":",ar[2].Substring(0,2));
            }
            else{
                x=12+Convert.ToInt16(ar[0]);
                result=string.Concat(x,":",ar[1],":",ar[2].Substring(0,2));
            }
        }
        else{
            if(ar[0]=="12")
            {
                result=string.Concat("00:",ar[1],":",ar[2].Substring(0,2));
            }
            else{
                result=string.Concat(ar[0],":",ar[1],":",ar[2].Substring(0,2));
            }
        }
        return result;
    }

    static void Main(string[] args) 
	{
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
