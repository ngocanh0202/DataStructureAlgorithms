using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sort
{
    public class bubble
    {
        public static void sort(int []a){
            for(int i = 0 ; i < a.Length ; i ++){
                Boolean check = true;
                for(int j = 0 ; j < a.Length - i -1  ; j ++){
                    if(a[j] > a[j + 1]){
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                        check = false;
                    }
                }
                if(check == true){
                    break;
                }
            }
        }
        public static void retrainingsort(int []a){
            for(int i = 0 ; i < a.Length ; i++){
                bool check = false;
                for(int j = 0; j < a.Length - 1 - i ; j++){
                    if(a[j] > a[j+1]){
                        check = true;
                        int value1 = a[j];
                        a[j] = a[j+1];
                        a[j] = value1;
                    }
                }
                if(check == false){
                    break;
                }
            }
        }
    }
}