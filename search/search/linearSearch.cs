using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace search
{
    public class linearSearch
    {
        public static Boolean search(int []a, int b){
            for(int i = 0 ; i < a.Length ; i ++){
                if(a[i] == b){
                    return true;
                }
            }
            return false;
        }
        public static Boolean search2(String a, char b){
            for(int i = 0 ; i < a.Length ; i ++){
                if(a[i].Equals(b)){
                    return true;
                }
            }
            return false;
        }
    }
}