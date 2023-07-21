using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the root of a binary tree, return the inorder traversal of its nodes' values.

 

Example 1:


Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up: Recursive solution is trivial, could you do it iteratively?

Test case 
[1,2,2,3,4,5,6,7,8,9,0]

*/
namespace GeneralMath
{
    public class BinaryTreeInorderTraversal
    {

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


        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            IList<int> list = new List<int>();
            HashSet<TreeNode> set = new HashSet<TreeNode>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                if (stack.Peek().left != null && !set.Contains(stack.Peek().left))
                {
                    stack.Push(stack.Peek().left);
                    continue;
                }
                else if (stack.Peek().left == null || (stack.Peek().left != null && set.Contains(stack.Peek().left)))
                {
                    list.Add(stack.Peek().val);
                    TreeNode tempNode = stack.Pop();
                    set.Add(tempNode);
                    if (tempNode.right != null && !set.Contains(tempNode.right))
                    {
                        stack.Push(tempNode.right);
                    }
                    continue;
                }

            }


            return list;
        }
    }
}