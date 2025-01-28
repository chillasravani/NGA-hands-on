using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    public class ArrayExamples
    {
        
        public void Arrayitem()
        {
            Console.WriteLine("Ïts the Initialization and Declaration of Single Array");
            Console.WriteLine("enter the size of the Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]+" ");
            }
        }

        public void Arrayitem2()
        {
            Console.WriteLine("its a 2d array");
            Console.WriteLine("enter the row size:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the column size:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
             Console.WriteLine();

            }
            

        }
        public void Arrayitem3()
        {
            Console.WriteLine("its the program to separate odd and even integers into separated Arrays");
            Console.WriteLine("This is the problem");
            Console.WriteLine("enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            int[][] jagged= new int[2][];
            int even = 0;
            int odd = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            jagged[0] = new int[even];
            jagged[1]=new int[odd];
            int evenindex = 0;
            int oddindex = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] % 2 == 0)
                {
                    jagged[0][evenindex++] = arr[i];
                }
                else
                {
                    jagged[1][oddindex++]= arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("these are the even elements");
            foreach (int ele in jagged[0])
            {
                Console.WriteLine( ele + " ");
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("these are odd elements ");
            foreach(int ele in jagged[1])
            {
                Console.WriteLine(ele + " ");
            }
        }
        public void arraymove()
        {
            int[] arr = { 1, 2, 0, 4, 3, 0, 5, 0 };
            int i = 0;
            int j = 0;
            while (i < arr.Length)
            {
                if (arr[i] == 0)
                {
                    i++;
                }
                else
                {
                    arr[j] = arr[i];
                    i++;
                    j++;
                }
            }
            while (j <arr.Length)
            {
                arr[j] = 0;
                j++;
            }

            for(int k=0; k<arr.Length; k++)
            {
                Console.WriteLine(arr[k]+" ");
            }
        }
        
    }
}

