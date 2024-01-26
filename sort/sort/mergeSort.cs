using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sort
{
    public class mergeSort
    {
        static int []? a;
        static int []? c;
        static void mergin(int left,int mid, int Right){
            int i = left, j = mid+1;
            int index = i;
            while(i <= mid && j <= Right){
                if(a[i] < a[j]){
                    c[index++] = a[i++];
                }else{
                    c[index++] = a[j++];
                }
            }

            while(j <= Right){
                c[index++] = a[j++];
            }
            while(i <= mid){
                c[index++] = a[i++];
            }
            for(int l = left ; l <= Right ; l ++){
                a[l] = c[l];
            }
        }
        static void sort(int left, int Right){
            if(left < Right){
                int mid = (left + Right) / 2;
                sort(left, mid);
                sort(mid+1,Right);
                mergin(left,mid, Right);
            }
        }
        public static void mergeSort_1(int []b){
            a = b;
            c = new int[a.Length];
            sort(0,a.Length-1);
        }
    }
    public class mergeSort2
    {
        static int []?array;
        static int []?arraySorted;
        static public void Merge(int left,int mid, int right){
            int i = left;
            int j = mid + 1;
            int index = i;
            while(i <= mid && j <= right){
                if(array[i] < array[j]){
                    arraySorted[index] = array[i];
                    index++;
                    i++;
                }
                else{
                    arraySorted[index] = array[j];
                    index++;
                    j++;
                }
            }
            while(i <= mid){
                arraySorted[index] = array[i];
                index++;
                i++;
            }
            while(j <= right){
                arraySorted[index] = array[j];
                index++;
                j++;
            }

            for(int l = left; l <= right; l++){
                array[l] = arraySorted[l];
            }

        }
        static public void Sort2(int left,int right){
            if(left != right){
                int mid = (left + right)/2;
                Sort2(left, mid);
                Sort2(mid+1, right);
                Merge(left, mid, right);
            }
        }
        static public void Sort1(int []a){
            array = a;
            arraySorted = new int[array.Length];
            int left = 0;
            int right = a.Length -1;
            Sort2(left, right);
        }
    }
}