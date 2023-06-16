using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given an m x n matrix mat, return an array of all the elements of the array in a diagonal order.

 

Example 1:


Input: mat = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,4,7,5,3,6,8,9]
Example 2:

Input: mat = [[1,2],[3,4]]
Output: [1,2,3,4]
 

Constraints:

m == mat.length
n == mat[i].length
1 <= m, n <= 104
1 <= m * n <= 104
-105 <= mat[i][j] <= 105*/
namespace Array
{
    public class FindDiagonalOrder
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            int[] res = new int[mat.Length * mat[0].Length];
            int count = 0;
            if (mat.Length < 2)
            {
                Console.Write("Active1");
                for (int k = 0; k < mat[0].Length; k++)
                {
                    res[count] = mat[0][k];
                    count++;

                }

                return res;
            }
            else if (mat[0].Length < 2)
            {
                Console.Write("Active2");
                for (int k = 0; k < mat.Length; k++)
                {
                    res[count] = mat[k][0];
                    count++;

                }

                return res;
            }


            int i = mat.Length - 1;
            int j = mat[i].Length - 1;
            bool isUpOrDown = ((mat.Length + mat[0].Length)) % 2 == 0 ? false : true;
            int[] sum = new int[2] { i, j };
            int startPoint = 0;


            Array.Reverse(res);
            return res;
        }


    }
}
