using System;
using System.Collections.Generic;

namespace LongestRepeatingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = longRepeat("a");
            int result = longRepeat("bdsagbgagggaaatttyyyyau");
            //int result = longRepeat("abbxccc");
            //int result = longRepeat("abcdefghijklmnopqrstuvwxyz");

            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }

        public static int longRepeat(string a_string)
        {
            // Not enough time for me to think this through

            int chr_cnt = 0;
            int max_cnt = 0;

            if (String.IsNullOrEmpty(a_string))
            {
                return max_cnt;
            }

            char a_chr = a_string[0];
            chr_cnt++;
            max_cnt++;

            for (int i = 1; i < a_string.Length; i++)
            {
                if (a_string[i] == a_chr)
                {
                    chr_cnt++;
                }
                else
                {
                    a_chr = a_string[i];
                    chr_cnt = 1;
                }

                if (chr_cnt > max_cnt)
                {
                    max_cnt = chr_cnt;
                }
            }

            return max_cnt;
        }
    }
}
