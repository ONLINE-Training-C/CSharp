using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStrings
{
    class StringOperations
    {
        public static void Countspaces(String str)
        {
            int i, l, spc;
            l = 0;
            spc = 0;


            for (i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    spc++;
                }

            }

            // Console.Write("Total length of the string is : {0}\n", l);
            Console.Write("Total no of white spaces in  string is : {0}\n", spc);

        }
        public  static void Reverse(String str)
        {
            int i, j, l = 0;
            string str2 = "";

            for (i = 0; i <= str.Length-1; i++)
            {
                Console.WriteLine(++l);
                
               
            }
            for (j = str.Length - 1; j >= 0; j--)
            {
                str2 = str2 + str[j];
            }
            Console.WriteLine("Total length of the string{0}:" + l);
            Console.Write("reverse string : {0}\n", str2);
        }
    }

}
