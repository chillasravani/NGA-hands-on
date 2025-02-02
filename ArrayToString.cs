using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    internal class ArrayToString
    {
        public static string  ArrayConcat(string[] arr)
        {
            string toStringConcat=string.Join("", arr);
            Console.WriteLine("Concatenated String:"+toStringConcat);
            return toStringConcat;
        }
        public static void NumberExtract(string toStringConcat)
        {
            //int[] num=new int[arr.Length];
            List<int> list = new List<int>();
            for (int i = 0; i < toStringConcat.Length; i++)
            {
                //Console.Write(toStringConcat[i]);
                char ch=toStringConcat[i];
                Console.Write(ch);
                if(ch>='0' && ch <= '9' && ch!=' ' )
                {
                    list.Add((int)ch-48);
                }
            }
            Console.WriteLine();
            //for (int i = 0; i < list.Count; i++) 
            //{
                Console.WriteLine("Extracted Numbers:["+string.Join(",",list)+"]");
            //}
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
                
            }
            Console.WriteLine("Maximum number is: " + max);
            int min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
                
            }
            Console.WriteLine("Minimum number is: " + min);
            Console.WriteLine("Difference Between Maximum number and Minimum number is: " + (max - min));


        }
        
        public class Program
        {
            public static void Main(string[] args)

            {
                string[] arr =  { "banana1", "apple2", "mango3" };
                ArrayToString s = new ArrayToString();
                string toStringConcat=ArrayConcat(arr);

                NumberExtract(toStringConcat);

            }
        }
    }

}
