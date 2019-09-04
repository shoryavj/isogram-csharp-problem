using System;
using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
    public static class Program
            {          public static void Main(string[] args)
                {
                              Console.WriteLine("Heloo");
                } 

            public static bool isogram(string text)
            {
            char[] str = text.ToCharArray();
            char[] newstr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && str[i] != '-')
                {
                    if (newstr.Contains(str[i]))
                    {
                        return false;                   
                            }
                    else
                    {
                        newstr[i] = str[i];
                    }
                }

            }

            return true;
        }
    }
}










