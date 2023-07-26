using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
https://leetcode.com/problems/01-matrix/

Given an m x n binary matrix mat, return the distance of the nearest 0 for each cell.

The distance between two adjacent cells is 1.

 

Example 1:


Input: mat = [[0,0,0],[0,1,0],[0,0,0]]
Output: [[0,0,0],[0,1,0],[0,0,0]]
Example 2:


Input: mat = [[0,0,0],[0,1,0],[1,1,1]]
Output: [[0,0,0],[0,1,0],[1,2,1]]
 

Constraints:

m == mat.length
n == mat[i].length
1 <= m, n <= 104
1 <= m * n <= 104
mat[i][j] is either 0 or 1.
There is at least one 0 in mat.

Test case 
[[0,0,1,0,1,1,1,0,1,1],[1,1,1,1,0,1,1,1,1,1],[1,1,1,1,1,0,0,0,1,1],[1,0,1,0,1,1,1,0,1,1],[0,0,1,1,1,0,1,1,1,1],[1,0,1,1,1,1,1,1,1,1],[1,1,1,1,0,1,0,1,0,1],[0,1,0,0,0,1,0,0,1,1],[1,1,1,0,1,1,0,1,0,1],[1,0,1,1,1,0,1,1,1,0]]

*[[0,0,1,0,1,1,1,0,1,1]
,[1,1,1,1,0,1,1,1,1,1]
,[1,1,1,1,1,0,0,0,1,1]
,[1,0,1,0,1,1,1,0,1,1]
,[0,0,1,1,1,0,1,1,1,1]
,[1,0,1,1,1,1,1,1,1,1]
,[1,1,1,1,0,1,0,1,0,1]
,[0,1,0,0,0,1,0,0,1,1]
,[1,1,1,0,1,1,0,1,0,1]
,[1,0,1,1,1,0,1,1,1,0]]

[[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,0,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1]]

*[[0,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,0,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,0]]

[[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1],[1,1,1,1,0,1,1,1,1,1],[1,1,1,1,1,1,1,1,1,1]]

*[[0,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,1]
,[1,1,1,1,0,1,1,1,1,1]
,[1,1,1,1,1,1,1,1,1,0]]
*/
namespace QueueStack
{
    public class Matrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            Stack<int[]> stack = new Stack<int[]>();
            HashSet<string> set = new HashSet<string>();


            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        stack.Push(new int[] { i, j });
                        set.Add(i+""+j);
                    }
                }
            }
            int count =0;
            while (stack.Count > 0)
            {
                int sum = Math.Abs(stack.Peek()[0] - stack.Peek()[1]);
                stack.Pop();
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        if (!set.Contains(i+""+j))
                        {
                            mat[i][j] = Math.Abs((i - j) + sum);
                        }
                    }
                }
                count ++;
            }



            return mat;
        }

    }



}


