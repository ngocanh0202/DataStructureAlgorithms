using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace search
{
    public class binarySearch
    {
        public static Boolean searchBinary(int []a, int b){
            int left = 0;
            int right = a.Length - 1;
            int mid = (left + right)  / 2;
            if(a[mid] == b){
                return true;
            }
            while(left ==  right){
                if(b < a[mid]){
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
                else if(a[mid] < b){
                    left = mid+ 1;
                    mid = (left + right) / 2;
                }
                else if(a[mid] == b){
                    return true;
                }
            }

            return false;
        }
    }
}