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
23 24
*/
namespace QueueStack
{
    public class Matrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            if (mat.Length == 0)
            {
                return new int[0][];
            }
            Queue<int[]> queue = new Queue<int[]>();



            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue(new int[] { i, j });
                        
                    }
                    else
                    {
                        mat[i][j] = int.MaxValue;
                    }
                }
            }


            while (queue.Count > 0)
            {
                Queue<int[]> queue1 = new Queue<int[]>();
                int i = queue.Peek()[0];
                int j = queue.Peek()[1];
                queue1.Enqueue(new int[]{i,j});
                queue.Dequeue();

                while (queue1.Count > 0)
                {
                    int i1 = queue1.Peek()[0];
                    int j1 = queue1.Peek()[1];
                    queue1.Dequeue();
                    if (i1 + 1 < mat.Length)
                    {
                        if (mat[i1 + 1][j1] != 0 && mat[i1 + 1][j1] > Math.Abs((i1 + 1) - i) + Math.Abs(j - j1))
                        {
                            mat[i1 + 1][j1] = Math.Abs((i1 + 1) - i) + Math.Abs(j - j1);
                           
                            queue1.Enqueue(new int[] { i1 + 1, j1 });

                        }

                    }
                    if (j1 + 1 < mat[0].Length)
                    {
                        if (mat[i1][j1 + 1] != 0 && mat[i1][j1 + 1] > Math.Abs((i1) - i) + Math.Abs(j - (j1 + 1)))
                        {
                            mat[i1][j1 + 1] = Math.Abs((i1) - i) + Math.Abs(j - (j1 + 1));
                            queue1.Enqueue(new int[] { i1, j1 + 1 });

                        }

                    }
                    if (i1 - 1 >= 0)
                    {
                        if (mat[i1 - 1][j1] != 0 && mat[i1 - 1][j1] > Math.Abs((i1 - 1) - i) + Math.Abs(j - (j1)))
                        {
                            mat[i1 - 1][j1] = Math.Abs((i1 - 1) - i) + Math.Abs(j - (j1));
                            queue1.Enqueue(new int[] { i1 - 1, j1 });

                        }

                    }
                    if (j1 - 1 >= 0)
                    {
                        if (mat[i1][j1-1] != 0 && mat[i1][j1-1] > Math.Abs((i1) - i) + Math.Abs(j - (j1-1)))
                        {
                            mat[i1][j1-1] = Math.Abs((i1) - i) + Math.Abs(j - (j1-1));
                            queue1.Enqueue(new int[] { i1, j1-1});

                        }
                    }


                }

            }




            return mat;
        }

        //Case study
        /*public int[][] UpdateMatrix(int[][] mat){
        // Two ways:
        // 1. BFS, find all zeros first, then walk from all zeros
        // to 1s that never walked on, the smaller distance 1s will
        // be walked on first than the larger distance ones

        // 2. Scan each node top-left, then bottom-right
        // Because the value of m[i][j] is decided by only those four
        // cells, and we can't get everything from one run, so we
        // scan the matrix twice

        return UpdateMatrixBfs(mat);
    }

     public int[][] UpdateMatrixBfs(int[][] mat)
     {
         var queue = new Queue<(int, int)>();

         for(var i = 0; i<mat.Length; i++)
         {
             for(var j = 0; j<mat[i].Length;j++)
             {
                 if(mat[i][j] == 0)
                 {
                     queue.Enqueue((i,j));
                 }
                 else
                 {
                     // Indicating it is not yet visited
                     mat[i][j] = -1;
                 }
             }
         }

         while(queue.Count > 0)
         {
             var pos = queue.Dequeue();
             var i = pos.Item1;
             var j = pos.Item2;
             // Extend to four directions
             SetDistance(mat, i, i + 1, j, j, queue);
             SetDistance(mat, i, i - 1, j, j, queue);
             SetDistance(mat, i, i, j, j + 1, queue);
             SetDistance(mat, i, i, j, j - 1, queue);
         }

         return mat;
     }

     void SetDistance(int[][] mat, int x0, int x, int y0, int y, Queue<(int, int)> queue)
     {
         if(x<0||x>=mat.Length||y<0||y>=mat[0].Length)
         {
             return;
         }

         if(mat[x][y]>=0)
         {
             // It means another smaller distance has been recorded
             // i.e. something walked on here first
             return;
         }

         mat[x][y] = mat[x0][y0] + 1;
         queue.Enqueue((x,y));
     }*/

    }



}


