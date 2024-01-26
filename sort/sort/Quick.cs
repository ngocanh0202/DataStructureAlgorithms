using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sort
{
    public class Quick
    {
        static int[] a;

        static int Partition(int left, int right)
        {
            int pivot = a[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    int temp1 = a[i];
                    a[i] = a[j];
                    a[j] = temp1;    
                }
            }

            int temp2 = a[i+1];
            a[i+1] = pivot;
            a[right] = temp2;

            return i + 1;
        }

        static void QuickSortAlgorithm(int left, int right)
        {
            if (left < right)
            {
                int partition = Partition(left, right);
                QuickSortAlgorithm(left, partition - 1);
                QuickSortAlgorithm(partition + 1, right);
            }
        }

        public static void Sort(int[] inputArray)
        {
            a = inputArray;
            QuickSortAlgorithm(0, a.Length - 1);
        }
    }
    public class Quick2
    {

        static int []?array;
        static int Sort(int left, int right)
        {
            int pivot = array[right];
            int i = left-1;
            int j = right;
            while (true)
            {
                while (pivot < array[--j] && j > 0) { } // Increment i while less than pivot

                while (pivot > array[++i]) { }  // Decrement j while greater than pivot

                if (i >= j)
                {
                    break;
                }
                else
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

             int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;

            return i+1;
        }
        static void quick(int left, int right){
            if(left < right){
                int partition = Sort(left, right);
                quick(left, partition - 1);
                quick(partition + 1, right);
            }
        }
        static public void QuickSort(int []a){
            array = a;
            int left = 0;
            int right = a.Length-1;
            quick(left, right);
        }
    }
}