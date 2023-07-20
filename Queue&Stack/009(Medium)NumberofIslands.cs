using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
 

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.


[["1","1","1"],["0","1","0"],["1","1","1"]]


[["1","1","1"],
 ["0","1","0"],
 ["1","1","1"]]
 
 [["1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","0","0","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"]]*/
namespace QueueStack
{
    public class NumberofIslands
    {
        public int NumIslands(char[][] grid)
        {

            Stack<int[]> stack = new Stack<int[]>();
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        stack.Push(new int[]{i,j});
                        grid[i][j] = '0';

                        while (stack.Count > 0)
                        {
                            int i1 = stack.Peek()[0];
                            int j1 = stack.Peek()[1];
                            stack.Pop();
                            if (i1 + 1 < grid.Length)
                            {
                                if (grid[i1 + 1][j1] == '1')
                                {
                                    stack.Push(new int[]{i1+1,j1});;
                                    grid[i1+1][j1] = '0';
                                }
                            }

                            if (j1 + 1 < grid[0].Length)
                            {
                                if (grid[i1][j1 + 1] == '1')
                                {
                                   stack.Push(new int[]{i1,j1+1});;
                                    grid[i1][j1 + 1] = '0';
                                }
                            }

                            if (i1 - 1 >= 0)
                            {
                                if (grid[i1 - 1][j1] == '1')
                                {
                                    stack.Push(new int[]{i1-1,j1});;
                                    grid[i1 - 1][j1] = '0';
                                }

                            }
                            if (j1 - 1 >= 0)
                            {
                                if (grid[i1][j1 - 1] == '1')
                                {
                                     stack.Push(new int[]{i1,j1-1});;
                                    grid[i1 ][j1-1] = '0';
                                }

                            }

                        }



                        count++;
                    }



                }

            }
            return count;

        }
    }
}