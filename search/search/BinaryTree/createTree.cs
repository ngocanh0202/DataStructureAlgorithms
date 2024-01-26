using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace search
{
    public class createTree
    {
        public static BinaryTree? binaryTree_root;
        public static BinaryTree? load(int value, BinaryTree? binaryTree1){
            if (binaryTree1 == null)
            {
                return new BinaryTree(value);
            }

            if (value <= binaryTree1.Node)
            {
                binaryTree1.Left = load(value, binaryTree1.Left);
            }
            else
            {
                binaryTree1.Right = load(value, binaryTree1.Right);
            }

            return binaryTree1;
        }

        public static void createTree_binary(int[] values){
            if (values == null || values.Length == 0)
            {
                binaryTree_root = null;
                return;
            }

            binaryTree_root = new BinaryTree(values[0]);

            for (int i = 1; i < values.Length; i++)
            {
                binaryTree_root = load(values[i], binaryTree_root);
            }
        }

        public static Boolean search(int a){
            BinaryTree tree = binaryTree_root;
            while(tree != null){
                if(a == tree.Node){
                    return true;
                }
                else if(a <=  tree.Node){
                    tree = tree.Left;
                }
                else if(a > tree.Node){
                    tree = tree.Right;
                }
            }
            return false;
        }
        
        public static void preorder(BinaryTree? a){
            if( a!=null){
                Console.WriteLine(a.Node);
                preorder(a.Left);
                preorder(a.Right);
            }
        }
        public static void inorder(BinaryTree? a){
            if( a!=null){
                preorder(a.Left);
                Console.WriteLine(a.Node);
                preorder(a.Right);
            }
        }
        public static void portnorder(BinaryTree? a){
            if( a!=null){
                preorder(a.Left);
                preorder(a.Right);
                Console.WriteLine(a.Node);
            }
        }
    }
}