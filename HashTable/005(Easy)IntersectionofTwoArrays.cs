using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.
 

Constraints:

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000*/
namespace HashTable
{
    public class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int[] minArr = nums1.Length < nums2.Length ? nums1.ToList() : nums2.ToList();
            int[] maxArr = nums2.Lengt > nums1.Length ? nums2.ToList() : nums1.ToList();

            HashSet<int> maxLen = new HashSet<int>();
            HashSet<int> minLen = new HashSet<int>();

            foreach (int i in minArr)
            {
                if (minLen.Contains(i))
                {
                    continue;
                }
                minLen.Add(i);
            }

            foreach (int i in maxArr)
            {
                if (maxLen.Contains(i))
                {
                    continue;
                }
                minLen.Add(i);
            }

            foreach (int i in minLen)
            {
                if (!maxLen.Contains(i))
                {
                    minLen.Remove(i);
                    continue;
                }
            }
            minArr = new int[minLen.Count()];
            int count = 0;
            foreach (int i in minLen)
            {
                minArr[count] = i;
                count++;
            }
            return minLen.ToArray();
        }
    }
}