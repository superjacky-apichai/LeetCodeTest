using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
 

Constraints:

1 <= nums.length <= 105
-231 <= nums[i] <= 231 - 1
0 <= k <= 105
 

Follow up:

Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
Could you do it in-place with O(1) extra space?*/
namespace ArrayAndArrayString
{
    public class Rotate
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (nums.Length > 1 && k > 0)
            {
                int sumLength = k;
                int pointer = 0;
                int temp = 0;
                int temp2 = 0;

                if (nums.Length % k == 0)
                {
                    while (pointer < k)
                    {
                        if (sumLength >= nums.Length)
                        {
                            sumLength = sumLength - nums.Length;

                        }
                        int count = 1;
                        temp = nums[sumLength];
                        nums[sumLength] = nums[pointer];
                        while (count <= nums.Length / k)
                        {
                            sumLength = (sumLength + k) % nums.Length;

                            temp2 = nums[sumLength];
                            nums[sumLength] = temp;
                            temp = temp2;
                            count++;



                        }

                        pointer++;
                        sumLength = (k + pointer) % nums.Length;

                    }


                }
                else
                {
                    temp = nums[sumLength];
                    nums[sumLength] = nums[0];
                    sumLength = (sumLength + k) % nums.Length;

                    for (pointer = 1; pointer < nums.Length; pointer++)
                    {
                        temp2 = nums[sumLength];
                        nums[sumLength] = temp;
                        temp = temp2;

                        sumLength = (sumLength + k) % nums.Length;
                        Console.Write(8 % 6);


                    }

                }

                nums.C

            }
        }

    }
}