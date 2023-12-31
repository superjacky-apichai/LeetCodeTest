using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104

TestCase
[1,3,5,6]
5
[1,3,5,6]
2
[1,3,5,6]
7
[1]
1
[-1]
3
*/
namespace ArrayAndArrayString
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int res= 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                  res =i;
                  break;
                }if(target> nums[i]){
                    res = i+1;
                }
            }

            return res;
        }
    }
}