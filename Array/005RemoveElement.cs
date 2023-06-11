using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/* Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int val = ...; // Value to remove
int[] expectedNums = [...]; // The expected answer with correct length.
                            // It is sorted with no values equaling val.

int k = removeElement(nums, val); // Calls your implementation

assert k == expectedNums.length;
sort(nums, 0, k); // Sort the first k elements of nums
for (int i = 0; i < actualLength; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2,_,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).
 

Constraints:

0 <= nums.length <= 100
0 <= nums[i] <= 50
0 <= val <= 100*/
namespace Array
{
    public class RemoveElement
    {


        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    count++;
                }

            }
            if (count == nums.Length)
            {

                nums = new int[0];
                return 0;
            }
            else
            {
                for (int i = nums.Length - 1; len < i; i--)
                {
                    if (nums[i] == val)
                    {
                        continue;
                    }
                    else
                    if (nums[i] != val)
                    {
                        while (len < i)
                        {
                            if (nums[len] == val)
                            {
                                break;
                            }
                            else
                            {
                                len++;
                            }
                        }
                        int backup = nums[i];
                        nums[i] = nums[len];
                        nums[len] = backup;

                    }




                }
            }

            return nums.Length - count;

        }

        public int RemoveElement1(int[] nums, int val)
        {
            if (nums.Length == 2)
            {
                if (nums[0] == val)
                {
                    int backup = nums[0];
                    nums[0] = nums[1];
                    nums[1] = backup;
                }
            }
            else if (nums.Length >= 3)
            {
                int backup = 0;
                for (int i = 1; i < nums.Length - 1; i++)
                {
                    if (nums[i - 1] == val && nums[i] != val)
                    {
                        backup = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i]=backup;

                    }

                    if(nums[i]==val && nums[i+1]!= val){
                        backup = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i]=backup;
                    }

                    if(nums[i-1]==)
                }
            }

            return nums;
        }

    }
}