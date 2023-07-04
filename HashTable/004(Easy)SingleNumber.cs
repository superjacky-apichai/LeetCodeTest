using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,1]
Output: 1
Example 2:

Input: nums = [4,1,2,1,2]
Output: 4
Example 3:

Input: nums = [1]
Output: 1
 

Constraints:

1 <= nums.length <= 3 * 104
-3 * 104 <= nums[i] <= 3 * 104
Each element in the array appears twice except for one element which appears only once.*/
namespace HashTable
{
    public class SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    set.Remove(i);
                    continue;
                }
                set.Add(i);

            }

           List<int> value = set.ToList();

            return value.ElementAt(0);
        }

    }
}