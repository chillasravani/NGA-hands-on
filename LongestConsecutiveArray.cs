using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    internal class LongestConsecutiveArray
    {

        static void LongestSub(int[] arr)
        {
            int onecount = 0;
            int zerocount = 0;
            int zerooccur = 0;
            int oneoccur = 0;

            for (int i = 0; i<arr.Length-1;i++)
            {

                if (arr[i] == 1 )
                {
                    onecount++;
                    oneoccur = Math.Max(onecount, oneoccur);
                zerocount = 0;

                }
                else if (arr[i] == 0 )
                {
                    zerocount++;
                    zerooccur=Math.Max(zerocount, zerooccur);
                 onecount = 0;
                }
            else if (arr[arr.Length - 1] == 1)
              {
                    oneoccur++;
              }
              else
              {
                    zerooccur++;
              }
               
               
                
                
            }
            if (oneoccur>zerooccur)
            {
                Console.WriteLine("Length of the consecutive ones is " + oneoccur);
            }
            else
            {
                Console.WriteLine("length of the consecutive zeroes is " + zerooccur);
            }
        }
        
        
        public class LongestSubArray
        {
            public static void Main1(string[] args)
            {
                Console.WriteLine("enter the size of the array:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + "  ");
                }


                //nsole.WriteLine("the size of longest Sub Array is:" + result);
                LongestSub(arr);
            }
        }
        
    }
}
