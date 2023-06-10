using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Could you minimize the total number of operations done?*/

namespace Array
{
    public class MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int[] nums2 = new int[nums.Length];
            int count = nums.Length - 1;
            int countE = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums2[count] = 0;
                    count--;
                }
                else
                {
                    nums2[countE] = nums[i];
                    countE++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                 nums[i] = nums2[i];
            }
        

        }

    }
}