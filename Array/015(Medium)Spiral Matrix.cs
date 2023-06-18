using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {        
        
            int[] res = new int[matrix.Length * matrix[0].Length];
            int count = 0;
            int i = 0;
            int j = 0;
            bool switchRowOrColum = false;
            bool switchUpAndLeftOrDownAndRigth = false;
            int maxRow = matrix.Length - 1;
            int maxColum = matrix[i].Length - 1;
            int minRow = 1;
            int minColum = 0;


            while (count < (matrix.Length * matrix[i].Length))
            {               
                res[count] = matrix[i][j];
                
                    count++;

                if (switchRowOrColum)
                {
                    if (switchUpAndLeftOrDownAndRigth)
                    {
                        i--;
                        if (i == minRow)
                        {
                            switchRowOrColum = false;
                        }
                    }
                    else if (!switchUpAndLeftOrDownAndRigth)
                    {
                        i++;
                        if (i == maxRow)
                        {
                            switchRowOrColum = false;
                        }
                    }

                }
                else if (!switchRowOrColum)
                {

                    if (switchUpAndLeftOrDownAndRigth)
                    {
                        j--;
                        if (j == minColum)
                        {
                            switchRowOrColum = true;

                        }
                    }
                    else if (!switchUpAndLeftOrDownAndRigth)
                    {
                        j++;

                        if (j == maxColum)
                        {
                            switchRowOrColum = true;
                        }
                    }
                }
                if (i == maxRow && j == maxColum)
                {
                    maxRow--;
                    maxColum--;
                    switchUpAndLeftOrDownAndRigth = true;
                }
                else if (i == minRow && j == minColum)
                {
                    minRow++;
                    minColum++;
                    switchUpAndLeftOrDownAndRigth = false;
                }

                  
            }


            return res.ToList();
        }
    }
}