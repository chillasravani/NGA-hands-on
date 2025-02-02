using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    internal class ReverseWords
    {
        static string Reverse(string s)

        {
            {
                string t = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    t = t + s[i];
                }
                return t;

            }
        }
        static void Reversewrds(string s)
        {

            string[] str = s.Split(' ');
            string[] reversed = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                reversed[i] = Reverse(str[i]);
            }
            for (int i = 0; i < reversed.Length; i++)
            {

                Console.Write(reversed[i].ToString() + " ");

            }
        }

        

        public class Program
        {
            public static void Main4(string[] args)
            {
                string s = "Hello how are you";
                Reversewrds(s);


            }
        }
    }
}

