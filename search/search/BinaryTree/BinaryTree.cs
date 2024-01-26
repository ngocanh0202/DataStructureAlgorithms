using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace search
{
    public class BinaryTree
    {
        int node;
        BinaryTree ?left;
        BinaryTree ?right;

        public BinaryTree(int node){
            this.Node = node;
        }

        public int Node { get => node; set => node = value; }
        public BinaryTree Left { get => left; set => left = value; }
        public BinaryTree Right { get => right; set => right = value; }
    }
}