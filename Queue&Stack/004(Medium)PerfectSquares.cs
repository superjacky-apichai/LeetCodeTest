using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an integer n, return the least number of perfect square numbers that sum to n.

A perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself. For example, 1, 4, 9, and 16 are perfect squares while 3 and 11 are not.

 

Example 1:

Input: n = 12
Output: 3
Explanation: 12 = 4 + 4 + 4.
Example 2:

Input: n = 13
Output: 2
Explanation: 13 = 4 + 9.
 

Constraints:

1 <= n <= 104*/
namespace QueueStack
{
    public class PerfectSquares
    {
        public int NumSquares(int n)
        {

            List<int> list = new List<int>();
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();
            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i * i <= n; i++)
            {
                list.Add(i * i);
                queue1.Enqueue(i * i);
                queue2.Enqueue(1);
                set.Add(i * i);
                if (i * i == n)
                {
                    return 1;
                }
            }

            while (queue1.Count > 0)
            {
                int value = queue1.Dequeue();
                int count = queue2.Dequeue() + 1;

                for (int i = 0; i < list.Count; i++)
                {
                   
                    if(value + list.ElementAt(i) == n){
                       
                        return count;
                    }else if(!set.Contains(value + list.ElementAt(i))){
                        queue1.Enqueue(value + list.ElementAt(i));
                        queue2.Enqueue(count);
                        set.Add(value + list.ElementAt(i));
                    }


                }


            }

            return -1;
        }

    }
}