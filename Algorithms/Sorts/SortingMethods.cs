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

        public static void MergeSort(this List<int> data)
        {
            var length = data.Count;
            if (length < 2)
                return;

            var center = length / 2;
            var list1 = data.GetRange(0, center);
            var list2 = data.GetRange(center, length - center);
            list1.MergeSort();
            list2.MergeSort();
            data = Merge(list1, list2);
        }

        private static List<int> Merge(List<int> list1, List<int> list2)
        {
            var merged = new List<int>(list1.Count + list2.Count);
            while(list1.Count + list2.Count > 0)
            {
                if (list1.Count < 1)
                {
                    merged.AddRange(list2);
                    return merged;
                } 
                if (list2.Count < 1)
                {
                    merged.AddRange(list1);
                    return merged;
                }
                if (list1[0] < list2[0])
                {
                    merged.Add(list1[0]);
                    list1.RemoveAt(0);
                } else
                {
                    merged.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }
            return merged;
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
