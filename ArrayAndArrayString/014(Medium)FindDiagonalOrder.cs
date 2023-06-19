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
            bool isUpOrDown = true;
            int i = 0;
            int j = 0;
            int lenRow = mat.Length - 1;
            int lenColum = mat[lenRow].Length - 1;


            while (i <= lenRow && j <= lenColum)
            {

                if (isUpOrDown)
                {
                    res[count] = mat[i][j];
                    count++;
                    j++;
                    i--;

                    if (j > lenColum)
                    {
                        j--;
                        i += 2;
                        isUpOrDown = false;

                    }
                    else if (i < 0)
                    {
                        isUpOrDown = false;
                        i++;
                        if (j > lenColum)
                        {
                            j--;
                        }


                    }


                }
                else if (!isUpOrDown)
                {
                    res[count] = mat[i][j];
                    count++;
                    j--;
                    i++;

                    if (i > lenRow)
                    {
                        i--;
                        j += 2;
                        isUpOrDown = true;

                    }
                    else if (j < 0)
                    {
                        isUpOrDown = true;
                        j++;
                        if (i > lenRow)
                        {
                            i--;
                        }

                    }

                }






            }


            return res;
        }


    }
}
