using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq2;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new() { 1.2, 5.4, 9.0, 2.7, 6.6 };
            List<int> myListInt = new() { 1,5,8,12,3,6 };
            List<int> EmptyList = new();
            /*List<double> myShortList = new();*/
            /*var myShortList = myList.Where2(num => num < 6.5).Where2(num => num > 5);*/
            /*foreach (var a in myShortList)
            {
                Console.WriteLine(a);
            }*/
            var myShortList = myList.Where2(num => num < 6.5);
            Console.WriteLine(@"
---------------------
");
            foreach (var a in myShortList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(@"
---------------------
");
                
        }
    }
}
