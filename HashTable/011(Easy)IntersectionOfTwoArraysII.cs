using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.
 

Constraints:

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000
 

Follow up:

What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?*/
namespace HashTable
{
    public class IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            int[] minimum = nums1.Length < nums2.Length ? nums1 : nums2;
            int[] maximim = nums2.Length > nums1.Length ? nums2 : nums1;
            Dictionary<int, int> dict = new Dictionary<int, int>();


            for (int i = 0; i < minimum.Length; i++)
            {
                for (int j = 0; j < maximim.Length; j++)
                {
                    if (minimum[i] == maximim[j] && !dict.ContainsKey(j))
                    {
                        dict[j] = minimum[i];
                        break;

                    }
                }

            }
           
           int[] res = dict
            .Select(x => x.Value)
            .ToArray();
           
            return res;

        }
    }
}