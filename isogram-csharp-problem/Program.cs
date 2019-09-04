using System;
using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
    public static class Program
            {          public static void Main(string[] args)
                {
                              Console.WriteLine("Hello World!!");
                } 

            public static bool isogram(string text)
            {
            char[] str = text.ToCharArray();
            char[] str2 = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '-' && str[i] != ' ')
                {
                    if (str2.Contains(str[i]))
                    {
                        return false;                   
                            }
                    else
                    {
                        str2[i] = str[i];
                    }
                }

            }

            return true;
        }
    }
}










