using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*You are given an integer array nums and an integer target.

You want to build an expression out of nums by adding one of the symbols '+' and '-' before each integer in nums and then concatenate all the integers.

For example, if nums = [2, 1], you can add a '+' before 2 and a '-' before 1 and concatenate them to build the expression "+2-1".
Return the number of different expressions that you can build, which evaluates to target.

 

Example 1:

Input: nums = [1,1,1,1,1], target = 3
Output: 5
Explanation: There are 5 ways to assign symbols to make the sum of nums be target 3.
-1 + 1 + 1 + 1 + 1 = 3
+1 - 1 + 1 + 1 + 1 = 3
+1 + 1 - 1 + 1 + 1 = 3
+1 + 1 + 1 - 1 + 1 = 3
+1 + 1 + 1 + 1 - 1 = 3
Example 2:

Input: nums = [1], target = 1
Output: 1
 

Constraints:

1 <= nums.length <= 20
0 <= nums[i] <= 1000
0 <= sum(nums[i]) <= 1000
-1000 <= target <= 1000*/
namespace QueueStack
{
    public class TargetSum
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0] == Math.Abs(target) ? 1 : 0;
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(+nums[0]);
            stack.Push(-nums[0]);
            int count = 0;


            for (int i = 1; i < nums.Length; i++)
            {
                Stack<int> temp = new Stack<int>();
                while (stack.Count > 0)
                {
                    int num = stack.Pop();

                    temp.Push(num - nums[i]);
                    if (i == nums.Length - 1 && temp.Peek() == target)
                    {
                        count++;
                    }
                    temp.Push(num + nums[i]);
                    if (i == nums.Length - 1 && temp.Peek() == target)
                    {
                        count++;
                    }

                }
                stack = temp;
            }



            return count;

        }
    }
}