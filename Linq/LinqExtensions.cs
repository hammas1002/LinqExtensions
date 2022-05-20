using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace System.Linq2
{
    static class LinqExtensions
    {
        public static IEnumerable<T> Where2<T>(this IEnumerable<T> e,Predicate<T> predicate)
        {
            List<T> tempList=new();
            foreach(var item in e)
            {
                if (predicate(item))
                {
                    tempList.Add(item);
                }
            }
            return tempList;
            
        }
        public static double Max2(this IEnumerable<double> e)
        {
            var myList = e.ToList();
            if (myList == null) { throw new InvalidOperationException(); }
            double maxNum = myList[0];
            foreach (var item in e)
            {
                if (maxNum < item) maxNum = item;
            }
            return maxNum;
        }
    }
}
