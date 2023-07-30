using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition. All the scores are guaranteed to be unique.

The athletes are placed based on their scores, where the 1st place athlete has the highest score, the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:

The 1st place athlete's rank is "Gold Medal".
The 2nd place athlete's rank is "Silver Medal".
The 3rd place athlete's rank is "Bronze Medal".
For the 4th place to the nth place athlete, their rank is their placement number (i.e., the xth place athlete's rank is "x").
Return an array answer of size n where answer[i] is the rank of the ith athlete.

 

Example 1:

Input: score = [5,4,3,2,1]
Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"]
Explanation: The placements are [1st, 2nd, 3rd, 4th, 5th].
Example 2:

Input: score = [10,3,8,9,4]
Output: ["Gold Medal","5","Bronze Medal","Silver Medal","4"]
Explanation: The placements are [1st, 5th, 3rd, 2nd, 4th].

 

Constraints:

n == score.length
1 <= n <= 104
0 <= score[i] <= 106
All the values in score are unique.*/

namespace GeneralMath
{
    public class RelativeRanks
    {
        public string[] FindRelativeRanks(int[] score)
        {
            Queue<int> stack = new Queue<int>();
            HashSet<int> set = new HashSet<int>();

            while (stack.Count != score.Length)
            {
                int arr = 0;
                int min = int.MinValue;
                for (int i = 0; i < score.Length; i++)
                {

                    if (min < score[i] && !set.Contains(i))
                    {
                        min = score[i];
                        arr = i;

                    }

                    set.Add(arr);
                    stack.Enqueue(arr);

                }

            }

            string[] strArr = new string[stack.Count];
            for (int i = 0; i < strArr.Length; i++)
            {

                switch (i)
                {

                    case 0:
                        strArr[stack.Peek()] = "Gold Medal";
                        break;
                    case 1:
                        strArr[stack.Peek()] = "Silver Medal";
                        break;
                    case 2:
                        strArr[stack.Peek()] = "Bronze Medal";
                        break;

                    default:
                        strArr[stack.Peek()] = (i + 1) + "";
                        break;
                }


            }

            return strArr;
        }

        /*Using Heap
        public string[] FindRelativeRanks(int[] score) {
          var res = new string[score.Length];

         PriorityQueue<int, int> q = new();

         for(var i = 0; i < score.Length; i++){
             q.Enqueue(i, score[i]*-1);
         }

         int k = 1;

         while(q.Count > 0){
             var idx = q.Dequeue();
             switch(k){
                 case 1: res[idx] = "Gold Medal"; break;
                 case 2: res[idx] = "Silver Medal"; break;
                 case 3: res[idx] = "Bronze Medal"; break;
                 default: res[idx] = $"{k}"; break;
             }
             k++;
         }

         return res;
     }*/



    }
}