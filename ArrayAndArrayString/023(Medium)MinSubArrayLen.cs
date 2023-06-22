using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

 

Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: target = 4, nums = [1,4,4]
Output: 1
Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
 

Constraints:

1 <= target <= 109
1 <= nums.length <= 105
1 <= nums[i] <= 104
 

Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).*/
namespace ArrayAndArrayString
{
    public class MinSubArrayLen
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int j = nums.Length - 1;
            int count = 0;
            if (nums.Length > 2)
            {
                while (j>=0)
                
                    if (nums[i] == target || nums[j] == target || nums[i + 1] == target || nums[j - 1] == target)
                    {
                        return 1;
                    }
                    else if(nums[i]+nums[i+1]==target||nums[j]+nums[j-1]==target||nums[i]+nums[j]==target)
                    { 
                        return 2;
                    }
                   
                }
            

            return 1;

        }

    }
}
