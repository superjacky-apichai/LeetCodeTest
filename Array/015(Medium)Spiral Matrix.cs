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

            while (count < res.Length)
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

                        if (j > maxColum)
                        {
                            j--;
                            i++;
                            switchRowOrColum = true;
                        }
                        else if (j == maxColum)
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




        /* Great Solution */

        public IList<int> SpiralOrder(int[][] matrix)  {
        int width=matrix[0].Length;
        int height=matrix.Length;
        int length=width*height;
        List<int> ans = new List<int>(length);
        int x=0,y=0,dx=1,dy=1;
        while(ans.Count<length)
        {
            ans.Add(matrix[y][x]);
            if(y==dy-1 && x<width-dx)
                x++;
            else if(x==width-dx && y<height-dy)
                y++;
            else if(x>dx-1) 
                x--;
            else if(y>dy)
            {
                y--;
                if(y==dy && x==dx-1)
                {
                    dx++;
                    dy++;
                }
            }
        }
        return ans;
    }
    }
}