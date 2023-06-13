using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.

 

Example 1:

Input: nums = [3,1,2,4]
Output: [2,4,3,1]
Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
Example 2:

Input: nums = [0]
Output: [0]*/
namespace Array
{
    public class SortArrayByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {

            int[] nums2 = new int[nums.Length];
            int countleft = 0;
            int countring = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums2[(nums2.Length-1)-countring] = nums[i];
                    countring ++;
                }else{
                    nums2[countleft] =nums[i];
                    countleft++;
                }

            }

            return nums2;

        }
    }
}