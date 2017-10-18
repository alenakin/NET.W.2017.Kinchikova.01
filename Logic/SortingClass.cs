using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SortingClass
    {
        public static void QuickSort(int[] array)
        {
            QSort(array, 0, array.Length - 1);
        }

        private static int Partition(int[] array, int left, int right)
        {
            int marker = left;
            for (int i = left; i <= right; i++)
            {
                if (array[i] < array[right])
                {
                    Swap(ref array[marker], ref array[i]);
                    marker++;
                }
            }
            Swap(ref array[marker], ref array[right]);
            return marker;
        }

        private static void QSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(array, left, right);
                QSort(array, left, p - 1);
                QSort(array, p + 1, right);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void MergeSort(int[] array)
        {
            MSort(array, 0, array.Length);
        }

        static void MSort(int[] array, int left, int right)
        {
            if (left + 1 < right)
            {
                int m = (left + right) / 2;
                MSort(array, left, m);
                MSort(array, m, right);
                Merge(array, left, m, right);
            }
        }

        static void Merge(int[] array, int left, int m, int right)
        {
            int l = 0, r = 0;
            int size = right - left;
            int[] result = new int[size];
            while (left + l < m && m + r < right)
                if (array[left + l] < array[m + r])
                {
                    result[l + r] = array[left + l];
                    l++;
                }
                else
                {
                    result[l + r] = array[m + r];
                    r++;
                }

            while (left + l < m)
            {
                result[l + r] = array[left + l];
                l++;
            }

            while (m + r < right)
            {
                result[l + r] = array[m + r];
                r++;
            }

            for (int i = 0; i < size; i++)
                array[left + i] = result[i];
        }
    }
}
