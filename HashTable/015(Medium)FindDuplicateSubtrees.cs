using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashTable
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class FindDuplicateSubtrees
    {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            Dictionary<TreeNode, int> dict = new Dictionary<TreeNode, int>();

            TreeNode temp = root;

           }
    }
}