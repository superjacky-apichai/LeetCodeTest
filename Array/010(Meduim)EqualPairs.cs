using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.

A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).

 

Example 1:

Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
Output: 1
[3,2,1]
[1,7,6]
[2,7,7]
Explanation: There is 1 equal row and column pair:
- (Row 2, Column 1): [2,7,7]

Example 2:
[3,1,2,2]
[1,4,4,5]
[2,4,2,2]
[2,4,2,2]
Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
Output: 3
Explanation: There are 3 equal row and column pairs:
- (Row 0, Column 0): [3,1,2,2]
- (Row 2, Column 2): [2,4,2,2]
- (Row 3, Column 2): [2,4,2,2]
 

Constraints:

n == grid.length == grid[i].length
1 <= n <= 200
1 <= grid[i][j] <= 105*/

namespace Array
{
    public class EqualPairs
    {
        public int EqualPairs(int[][] grid)
        {
            int count = 0;
            bool eaqualCheck;

            for (int i = 0; i < grid.Length; i++)
            {
                eaqualCheck = false;
                for (int j = 0; j < grid.Length; j++)
                {
                    for (int k = 0; k < grid.Length; k++)
                    {
                        j = 0;
                        for (int l = 0; l < grid.Length; l++)
                        {

                            if (grid[l][k] == grid[i][j])
                            {
                                j++;
                                eaqualCheck = true;
                            }
                            else
                            {
                                eaqualCheck = false;
                                break;
                            }
                        }
                        if (eaqualCheck)
                        {
                            count++;

                        }

                    }
                    break;
                }
            }
            return count;
        }

    }
}
