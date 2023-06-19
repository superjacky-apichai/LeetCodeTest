using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array
{

    /*Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:


 

Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
 

Constraints:

1 <= numRows <= 30*/
    public class pascalsTriangle
    {

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> layer1 = new List<IList<int>>();
            if (numRows < 2)
            {
                layer1.Add(new List<int> { 1 });
            }
            else
            {
                layer1.Add(new List<int> { 1 });
                layer1.Add(new List<int> { 1, 1 });
            }


            for (int i = 3; i <= numRows; i++)
            {
                IList<int> layer2 = new List<int>();
                layer2.Add(1);
                for (int j = 0; j < layer1[i - 2].Count - 1; j++)
                {
                    layer2.Add(layer1[i - 2][j] + layer1[i - 2][j + 1]);
                }
                layer2.Add(1);
                layer1.Add(layer2);

            }


            return layer1;
        }

    }
}