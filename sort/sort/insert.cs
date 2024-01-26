using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sort
{
    public class insert
    {
        public static void sort(int []a)
        {
            for(int i = 1 ; i < a.Length ; i ++){
                int b = a[i];
                int j = i;
                while(j > 0 && b < a[j-1]){
                    a[j] = a[j-1];
                    j --;
                }
                if(j != i){
                    a[j] = b;
                }
            }
        }
        public static void retrainingsort(int []a){
            for(int i = 1 ; i < a.Length ; i++){
                int j = i;
                int index = a[j];
                while(j > 0 && a[j-1] > index ){
                    a[j] = a[j-1];
                    j--;
                }
                if(j != i){
                    a[j] = index;
                }
            }
        }


    }
}