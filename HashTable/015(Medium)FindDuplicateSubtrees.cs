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

            IList<TreeNode> list = new List<TreeNode>();
            traverse(root, new Dictionary<string, int>(), new Dictionary<int, int>(), list);

            return list;

        }


        public int traverse(TreeNode node, Dictionary<string, int> tripletToID, Dictionary<int, int> cnt, IList<TreeNode> res)
        {
            if(node==null){
                return 0;
            }

            string triplet = traverse(node.left,tripletToID,cnt,res)+","+node.val+","+traverse(node.right,tripletToID,cnt,res);
            Console.WriteLine(triplet);
            if(!tripletToID.ContainsKey(triplet)){
                tripletToID.Add(triplet,tripletToID.Count+1);
            }
            int id = tripletToID[triplet];
            cnt[id] = cnt.GetValueOrDefault(id, 0) + 1;
            if(cnt[id]==2){
                res.Add(node);
            }
            return id;

        }

    }

}

