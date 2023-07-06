using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylListExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(10); // boxing
            list.Add("Hello");
            list.Add(77.77);

            string s = list[1].ToString();
            int a = (int)list[0]; // unboxing
            Console.WriteLine(a);

            double d = (double)list[2];
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Array List Example");

            int[] arr = new int[] { 10, 20, 30 };
            int[] arr2 = new int[8];
            ArrayList list1 = new ArrayList();

            list1.Add(11);
            list1.Add(33);
            list1.Add(77);

            list1.Insert(0, 1);
            list1.Insert(2, 200);

            list1.AddRange(arr);

            //list1.Remove("Hello");
            //list1.RemoveAt(0);
            //list1.RemoveRange(1, 3);

            list1.Sort();
            list1.Reverse();

            list1.CopyTo(arr2);

            bool res = list1.Contains(250);
            Console.WriteLine(res);

            Console.WriteLine("No of elements present in the collection " + list1.Count);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
