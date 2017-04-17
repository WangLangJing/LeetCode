using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 二叉树后根次序遍历
/// </summary>
namespace BinaryTreePostorderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        private void RecursionTraversal(IList<int> traversalReuslt, TreeNode root)
        {
            if (root != null)
            {
                traversalReuslt.Insert(0, root.val);
                if (root.right != null)
                    RecursionTraversal(traversalReuslt, root.right);
                if (root.left != null)
                    RecursionTraversal(traversalReuslt, root.left);
            }
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            TreeNode tail = root;
            IList<int> traversal = new List<int>();
            RecursionTraversal(traversal, root);
            return traversal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(1);
            node.left = new TreeNode(2);
            node.left.right = new TreeNode(3);
            node.left.left = new TreeNode(5);
            node.right = new TreeNode(4);
            Solution test = new Solution();
            foreach (int num in test.PostorderTraversal(node))
            {
                Console.WriteLine(num);
            }
        }
    }
}
