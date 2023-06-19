using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

 

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2]
 

Constraints:

n == nums.length
1 <= n <= 105
1 <= nums[i] <= n
 

Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.*/
namespace Array
{
    public class FindDisappearedNumbers
    {

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            if (nums.Length == 0 || nums == null)
            {
                return nums.ToList();
            }

            IList<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int val = nums[i];

                while (nums[i] != val - 1 && nums[val - 1] != i + 1)
                {

                    int temp = nums[i];
                    nums[i] = nums[val - 1];
                    nums[val - 1] = temp;
                    val = nums[i];

                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                   if(nums[i] != i+1){
                    ans.Add(i);
                   }
            }

            return ans;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = Enumerable.Range(1, nums.Length).Except(nums);


            return result.ToList();
        }

    }
}