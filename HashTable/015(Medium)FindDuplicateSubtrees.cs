using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the root of a binary tree, return all duplicate subtrees.

For each kind of duplicate subtrees, you only need to return the root node of any one of them.

Two trees are duplicate if they have the same structure with the same node values.

 

Example 1:


Input: root = [1,2,3,4,null,2,4,null,null,4]
Output: [[2,4],[4]]
Example 2:


Input: root = [2,1,1]
Output: [[1]]
Example 3:


Input: root = [2,2,2,3,null,3,null]
Output: [[2,3],[3]]
 

Constraints:

The number of the nodes in the tree will be in the range [1, 5000]
-200 <= Node.val <= 200*/
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
            Dictionary<string, int> dict = new Dictionary<string, int>();
            IList<TreeNode> list = new List<TreeNode>();
            TreeNode temp = root;

            while (temp != null)
            {
                if (temp.left != null)
                {
                    TreeNode tempLeft = temp;
                    while (tempLeft != null)
                    {
                        string key = "";
                         TreeNode tempLeft = temp == root ? temp.left: temp;

                        tempLeft.right =null;
                        while (findbutoom != null)
                        {

                            key += findbutoom.val;
                            findbutoom = findbutoom.left;

                        }
                        Console.WriteLine(key);
                        if (dict.ContainsKey(key) && dict[key] < 1)
                        {
                            tempLeft.right = null;
                            list.Add(tempLeft);

                            dict[key]++;
                        }
                        else
                        {
                            dict[key] = 0;
                        }
                        tempLeft = tempLeft.left;
                    }
                }
                else if (temp.right == null)
                {
                    if (dict.ContainsKey(temp.val + "") && dict[temp.val + ""] < 1)
                    {
                        Console.WriteLine("Active");

                        list.Add(temp);
                        dict[temp.val + ""]++;
                    }
                }
                temp = temp.right;

            }

            return list;
        }

    }
}
