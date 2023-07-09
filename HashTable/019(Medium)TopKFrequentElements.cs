using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.
 

Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.*/
namespace HashTable
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict1 = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                dict1[nums[i]] = dict1.GetValueOrDefault(nums[i], 0) + 1;

            }
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            while (k > 0)
            {
                int cout = 0;
                int key;

                foreach (var i in dict1)
                {
                    if (cout < i.Value && !dict2.ContainsKey(i.Key))
                    {
                        cout = i.Value;
                        key = i.Key;
                    }
                }

                dict2[key] = k;
            }
            return dict2.Keys.ToArray();
        }
    }
}