using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]
 

Constraints:

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100*/

namespace QueueStack
{
    public class DailyTemperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int len = temperatures.Length;
            if (len == 1)
            {
                return new int[0];
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(len - 1);
            int[] res = new int[len];
    

            for (int i = len-2; i >= 0; i--)
            { 
                while(stack.Count !=0){
                    if(temperatures[stack.Peek()]>temperatures[i]){
                        res[i] = stack.Peek()-i;
                        break;
                    }

                    stack.Pop();
                }

                stack.Push(i);

            }

           return res;
        }
    }
}