using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Can you find an O(n) solution?*/
namespace Array
{
    public class ThirdMax
    {
        public int ThirdMax(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int[] ThirdMaxValue = new int[3] { Int32.MinValue, Int32.MinValue, Int32.MinValue };
            int temp;
            bool isContainMin = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == Int32.MinValue)
                {
                    isContainMin = true;
                }
                if ((ThirdMaxValue[0] < nums[i]) && (nums[i] != ThirdMaxValue[1] && nums[i] != ThirdMaxValue[2]))
                {
                    ThirdMaxValue[0] = nums[i];

                }

                if (ThirdMaxValue[0] > ThirdMaxValue[1])
                {
                    temp = ThirdMaxValue[0];
                    ThirdMaxValue[0] = ThirdMaxValue[1];
                    ThirdMaxValue[1] = temp;
                }

                if (ThirdMaxValue[1] > ThirdMaxValue[2])
                {
                    temp = ThirdMaxValue[1];
                    ThirdMaxValue[1] = ThirdMaxValue[2];
                    ThirdMaxValue[2] = temp;
                }

            }

            if (ThirdMaxValue[0] == Int32.MinValue && ThirdMaxValue[1] == Int32.MinValue || ThirdMaxValue[0] == Int32.MinValue && !isContainMin)
            {
                Console.Write("Active");
                return Math.Max(ThirdMaxValue[1], ThirdMaxValue[2]);
            }
            return ThirdMaxValue[0];

        }



    }
}