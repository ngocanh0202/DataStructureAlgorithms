using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace search
{
    public class LinkedList
    {
        int node;
        LinkedList? next;
        public LinkedList(int node){
            this.Node = node;
        }

        public int Node { get => node; set => node = value; }
        public LinkedList? Next { get => next; set => next = value; }
    }

    public class createList{
        private static LinkedList? linkedList;
        public static void create (int []a){
            linkedList = new LinkedList(a[0]);
            LinkedList newlinkedList = linkedList;
            for(int i = 1; i < a.Length; i++){
                LinkedList newNode = new LinkedList(a[i]);
                newlinkedList.Next = newNode;
                newlinkedList = newlinkedList.Next;
            }
        }
        public static void print (){
            LinkedList a = linkedList;
            while(a!=null){
                Console.WriteLine(a.Node);
                a = a.Next;
            }
        }
    }
}