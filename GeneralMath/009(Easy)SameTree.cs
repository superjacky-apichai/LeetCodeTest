using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 

Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104*/
namespace GeneralMath
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

    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (q == null && p == null)
            {
                return true;
            }
            else if (q == null)
            {
                return false;
            }
            else if (p == null)
            {
                return false;
            }

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();
            HashSet<TreeNode> set = new HashSet<TreeNode>();
            stack1.Push(p);
            stack2.Push(q);
            set.Add(q);

            while (stack1.Count > 0)
            {
                TreeNode qNode = stack1.Peek();
                TreeNode pNode = stack2.Peek();
                if (qNode.val != pNode.val)
                {
                    return false;
                }
                else if (qNode.left != null && pNode.left != null && !set.Contains(qNode.left))
                {
                    stack1.Push(qNode.left);
                    stack2.Push(pNode.left);
                    set.Add(qNode.left);
                    continue;
                }
                else if ((qNode.left == null && pNode.left == null) || ((qNode.left != null && pNode.left != null) && set.Contains(qNode.left)))
                {
                    stack1.Pop();
                    stack2.Pop();
                    if (qNode.right != null && pNode.right != null)
                    {

                        if (!set.Contains(qNode.right))
                        {
                            stack1.Push(qNode.right);
                            stack2.Push(pNode.right);
                        }
                        continue;
                    }
                    else if (qNode.right == null && pNode.right == null)
                    {

                        continue;
                    }

                    return false;

                }
                return false;
            }
            return true;
        }
    }
}