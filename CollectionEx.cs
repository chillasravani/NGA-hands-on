using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_NGA
{
    internal class CollectionEx
    {
        public class ArraysCollec
        {
            public static void Main(String[] args)
            {
                ArrayList arl = new ArrayList();
                arl.Add(1);
                arl.Add("ATP");
                arl.Add("Ap");

                int firstele = (int)arl[0];
                string secondele=(string)arl[1];
                Console.WriteLine($"firstelement is { firstele},secondElement is{secondele}");

                Console.WriteLine("With using var keyword,no need to explicitly convert");
                var first=arl[0];
                var second=arl[1];
                Console.WriteLine($"first item is {first},second item is{second}");
                for (int i = 0; i < arl.Count; i++)
                {
                    Console.WriteLine(arl[i]);
                }
                Console.WriteLine();
                arl.RemoveAt(2);
                for (int i = 0; i < arl.Count; i++)
                {
                    Console.WriteLine(arl[i]);
                }
                arl[1] = "Indian";
                for (int i = 0; i < arl.Count; i++)
                {
                    Console.WriteLine(arl[i]);
                }

                Console.WriteLine("Using foreach");
                foreach(object obj in arl)
                {
                    Console.WriteLine(obj);
                }
                foreach(var item in arl)
                {
                    Console.WriteLine(item);
                }

                arl.Insert(0, "agraharam");
                arl.Insert(1, "Tdm");

                foreach(var item in arl)
                {
                    Console.WriteLine(item);
                }
                ArrayList arl2 = new ArrayList()
                {
                    "Andhra",
                    "Ind"

                };
                arl.InsertRange(1, arl2);
                foreach(var item in arl2)
                {
                    Console.WriteLine(item);
                }
                ArrayList arl3 = new ArrayList()
                {
                    "one",
                    "two",
                    "three",
                    "four",
                    "five"
                };
                foreach (var item in arl3)
                {
                    Console.WriteLine(item);
                }
                arl3.Remove("five");
                foreach (var item in arl3)
                {
                       Console.WriteLine(item);
                }
                arl3.RemoveAt(2);
                foreach (var item in arl3)
                {
                    Console.WriteLine(item);
                }
                arl.RemoveRange(2, 3);
                foreach (var item in arl3)
                {
                    Console.WriteLine(item);
                }
                arl3.Clear();
                Console.WriteLine("al3 deleted now,capacity is now"+arl.Count);

                ArrayList arl4 = new ArrayList()
                {
                    "moksha",
                    "varhsa",
                    "chintu",
                    "bunty",
                    "shyamu",
                    "roja"
                };
                foreach (var item in arl4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("does the list contains bunny :" + arl4.Contains("Bunny"));
                Console.WriteLine("does the list contains roja :" + arl4.Contains("roja"));

                ArrayList cloningarl4=(ArrayList)arl4.Clone();
                foreach (var item in cloningarl4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("copying one array into another");
                object[] copyingArray=new object[arl4.Count];
                arl4.CopyTo(copyingArray);
                foreach (var item in copyingArray)
                {
                    Console.WriteLine(item);
                }
                
                arl4.Sort();
                Console.WriteLine("After sorting arl4 arraylist:");
                foreach (var item in arl4)
                {
                    Console.WriteLine(item);
                }



            }

        }
    }
}
