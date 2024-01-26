using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sort
{
    public class Fibonacci
    {
        public static int display(int endpoint){
            int n1 = 1;
            int n2 = 1;
            int n = 1;
            int i = 1;
            while(i != endpoint){
                n2 = n2 + n;
                n = n1;
                n1 = n2;
                i++;
            }
            return n;
        }
    }
}