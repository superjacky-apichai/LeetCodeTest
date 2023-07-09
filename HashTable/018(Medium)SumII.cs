using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given four integer arrays nums1, nums2, nums3, and nums4 all of length n, return the number of tuples (i, j, k, l) such that:

0 <= i, j, k, l < n
nums1[i] + nums2[j] + nums3[k] + nums4[l] == 0
 

Example 1:

Input: nums1 = [1,2], nums2 = [-2,-1], nums3 = [-1,2], nums4 = [0,2]
Output: 2
Explanation:
The two tuples are:
1. (0, 0, 0, 1) -> nums1[0] + nums2[0] + nums3[0] + nums4[1] = 1 + (-2) + (-1) + 2 = 0
2. (1, 1, 0, 0) -> nums1[1] + nums2[1] + nums3[0] + nums4[0] = 2 + (-1) + (-1) + 0 = 0
Example 2:

Input: nums1 = [0], nums2 = [0], nums3 = [0], nums4 = [0]
Output: 1
 

Constraints:

n == nums1.length
n == nums2.length
n == nums3.length
n == nums4.length
1 <= n <= 200
-228 <= nums1[i], nums2[i], nums3[i], nums4[i] <= 228*/
namespace HashTable
{
    public class SumII
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> dict1 = new Dictionary<int, int>();



            for (int i = 0; i < nums1.Length; i++)
            {

                for (int j = 0; j < nums2.Length; j++)
                {

                    dict1[nums1[i] + nums2[j]] = dict1.GetValueOrDefault(nums1[i] + nums2[j], 0) + 1;

                }

            }
            int count = 0;
            for (int i = 0; i < nums3.Length; i++)
            {


                for (int j = 0; j < nums4.Length; j++)
                {

                    if (nums3[i] + nums4[j] < 0 && dict1.ContainsKey(Math.Abs(nums3[i] + nums4[j])))
                    {
                        count += dict1[Math.Abs(nums3[i] + nums4[j])];

                    }
                    else if (nums3[i] + nums4[j] > 0 && dict1.ContainsKey(-(nums3[i] + nums4[j])))
                    {
                        count += dict1[-(nums3[i] + nums4[j])];
                    }
                    else if (nums3[i] + nums4[j] == 0 && dict1.ContainsKey(0))
                    {
                        count += dict1[0];
                    }

                }

            }



            return count;
        }

    }
}