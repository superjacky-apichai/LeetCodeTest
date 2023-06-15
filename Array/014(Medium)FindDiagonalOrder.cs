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
            IList<int> res = new List<int>();
            if (mat.Length < 1)
            {
                for (int i = 0; i < mat.Rank; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        res.Add(mat[i][j]);
                    }
                }

                return res.ToArray();
            }
            else if (mat[0].Length < 1)
            {
                for (int i = 0; i < mat.Rank; i++)
                {
                    
                        res.Add(mat[i][0]);
                    
                }
            }

            bool isUpOrDown = true;
            for (int i = 0; i < mat.Length; i++)
            {
                int count = i;
                for (int j = 0; j < mat.Length; j++)
                {
                    int coutj = j;
                    if (isUpOrDown)
                    {
                        res.Add(mat[count][j]);
                    }
                    else if (!isUpOrDown)
                    {
                        res.Add(mat[j][count]);
                    }


                    if (j == i)
                    {
                        isUpOrDown = isUpOrDown ? false : true;
                        break;
                    }
                    count--;

                }
            }


            for (int j = 1; j < mat.Length; j++)
            {
                int len = mat.Length - 1;
                int countj = j;
                while (true)
                {
                    if (isUpOrDown)
                    {
                        res.Add(mat[len][countj]);
                    }
                    else if (!isUpOrDown)
                    {
                        res.Add(mat[countj][len]);
                    }
                    len--;
                    countj++;

                    if (j > len)
                    {
                        isUpOrDown = isUpOrDown ? false : true;
                        break;
                    }


                }

            }

            return res.ToArray();
        }


    }
}
