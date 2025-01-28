using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_NGA;

namespace ConsoleApp1_NGA
{
    internal class Arraymove

    {
        public class Moving
        {


            public void arrays()
            {
                Console.WriteLine("enter the size of the array");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                //for (int i = 0; i < arr.Length; i++)
                //{
                //Console.Write(arr[i] + " ");
                //}

                int k = 0;
                int j = 0;
                while (k < arr.Length)
                {
                    if (arr[k] == 0)
                    {
                        k++;
                    }
                    else
                    {
                        arr[j] = arr[k];
                        k++;
                        j++;
                    }
                }
                while (j < arr.Length)
                {
                    arr[j] = 0;
                    j++;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

            }


        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Arraymove.Moving move=new Arraymove.Moving();
            move.arrays();
        }


    }
}
   
