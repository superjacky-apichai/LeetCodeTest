using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:


 

Example 1:

Input: rowIndex = 3
Output: [1,3,3,1]
Example 2:

Input: rowIndex = 0
Output: [1]
Example 3:

Input: rowIndex = 1
Output: [1,1]
 

Constraints:

0 <= rowIndex <= 33
 

Follow up: Could you optimize your algorithm to use only O(rowIndex) extra space?*/
namespace ArrayAndArrayString
{
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
       {
            IList<IList<int>> layer1 = new List<IList<int>>();
            if (rowIndex < 2)
            {
                layer1.Add(new List<int> { 1 });
            }
            else
            {
                layer1.Add(new List<int> { 1 });
                layer1.Add(new List<int> { 1, 1 });
            }


            for (int i = 3; i <= rowIndex+1; i++)
            {
                IList<int> layer2 = new List<int>();
                layer2.Add(1);
                for (int j = 0; j < layer1[i - 2].Count - 1; j++)
                {
                    layer2.Add(layer1[i - 2][j] + layer1[i - 2][j + 1]);
                }
                layer2.Add(1);
                layer1.Add(layer2);
               if(i==rowIndex+1){
                return layer2;
               }

            }
               return rowIndex == 0 ? new List<int> { 1 }:new List<int> { 1, 1 };

            
        }
    }
}