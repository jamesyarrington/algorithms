using System;
using System.Collections.Generic;

namespace Sorts
{
    public static class SortingMethods
    {
        public static List<int> QuickSort(this List<int> data)
        {
            if (data.Count < 2)
                return data;
            var pivot = data[0];
            var lessElements = new List<int>();
            var greaterElements = new List<int>();
            for (var i = 1; i < data.Count; i++)
            {
                if (data[i] < pivot)
                {
                    lessElements.Add(data[i]);
                }
                else
                {
                    greaterElements.Add(data[i]);
                }
            }
            var sorted = lessElements.QuickSort();
            sorted.Add(pivot);
            sorted.AddRange(greaterElements.QuickSort());
            return sorted;
        }

        public static int[] QuickSort(this int[] data)
        {
            var aListOnTheInside = new List<int>();
            aListOnTheInside.AddRange(data);
            return aListOnTheInside.QuickSort().ToArray();
        }

        public static void QuickSortInPlace(this int[] data, int start = 0, int end = 0)
        {
            if (end == 0)
            {
                end = data.Length - 1;
            }
            if (end - start < 2)
                return;

            var pivot = data[start];

            var shifts = 0;

            for (var i = start + 1; i < end; i++)
            {
                if (data[i] < data[start])
                {
                    shifts++;

                }
            }


        }
    }
}
