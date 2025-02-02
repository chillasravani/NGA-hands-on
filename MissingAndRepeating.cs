using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    internal class MissingAndRepeating
    {
        static void MissingAndRepeat(int[] arr) { 
        
             Array.Sort(arr );

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i + 1] - arr[i]!=1) && arr[i + 1] > arr[i])
                {
                    int missing = arr[i + 1] - 1;
                    Console.WriteLine("Missing Number is " + missing);
                    break;
                }
                
            }
            for(int i = 0; i < arr.Length - 1; i++) { 
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine("Repeated Number is " + arr[i]);
                }
            }
        }
        public class MissAndRepeat
        {
            public static void Main2(string[] args)
            {
                int[] arr = { 1, 2, 9, 8, 5, 3, 4, 6, 5 };
                MissingAndRepeat(arr);
            }
        }
    }
}
