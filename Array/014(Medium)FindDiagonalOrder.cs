using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
