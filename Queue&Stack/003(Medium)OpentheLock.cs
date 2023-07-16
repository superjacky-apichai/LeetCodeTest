using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*You have a lock in front of you with 4 circular wheels. Each wheel has 10 slots: '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'. The wheels can rotate freely and wrap around: for example we can turn '9' to be '0', or '0' to be '9'. Each move consists of turning one wheel one slot.

The lock initially starts at '0000', a string representing the state of the 4 wheels.

You are given a list of deadends dead ends, meaning if the lock displays any of these codes, the wheels of the lock will stop turning and you will be unable to open it.

Given a target representing the value of the wheels that will unlock the lock, return the minimum total number of turns required to open the lock, or -1 if it is impossible.

 

Example 1:

Input: deadends = ["0201","0101","0102","1212","2002"], target = "0202"
Output: 6
Explanation: 
A sequence of valid moves would be "0000" -> "1000" -> "1100" -> "1200" -> "1201" -> "1202" -> "0202".
Note that a sequence like "0000" -> "0001" -> "0002" -> "0102" -> "0202" would be invalid,
because the wheels of the lock become stuck after the display becomes the dead end "0102".
Example 2:

Input: deadends = ["8888"], target = "0009"
Output: 1
Explanation: We can turn the last wheel in reverse to move from "0000" -> "0009".
Example 3:

Input: deadends = ["8887","8889","8878","8898","8788","8988","7888","9888"], target = "8888"
Output: -1
Explanation: We cannot reach the target without getting stuck.
 

Constraints:

1 <= deadends.length <= 500
deadends[i].length == 4
target.length == 4
target will not be in the list deadends.
target and deadends[i] consist of digits only.

Test Case
["2110","2000","0000","2111","1110"]
"0012"

deadends =
["1301","0113","0202","0122","3012","0131","0200","0203","1232","0222"]
target =
"2311"

deadends =
["1131","1303","3113","0132","1301","1303","2200","0232","0020","2223"]
target =
"3312"

*/
namespace QueueStack
{
    public class OpentheLock
    {
        public int OpenLock(string[] deadends, string target)
        {
            HashSet<string> set = new HashSet<string>(deadends);
            if (set.Contains("0000"))
            {
                return -1;
            }
            else if (target == "0000")
            {
                return 0;
            }
            Queue<char[]> queue = new Queue<char[]>();
            Queue<int> queuenum = new Queue<int>();
            HashSet<string> checker = new HashSet<string>();
            queue.Enqueue(new char[] { '0', '0', '0', '0' });
            queuenum.Enqueue(0);



            while (queue.Count > 0)
            {
                char[] chArr = queue.Dequeue();
                int num = queuenum.Dequeue() + 1;
                
                for (int i = 0; i < 4; i++)
                {
                    char[] chArr1 = new string(chArr).ToCharArray();

                    if (chArr1[i] == '9')
                    {
                        chArr1[i] = '0';
                    }
                    else
                    {
                        chArr1[i]++;
                    }

                    if (new string(chArr1) == target)
                    {
                        return num;
                    }
                    else if (!set.Contains(new string(chArr1)) && !checker.Contains(new string(chArr1)))
                    {
                        checker.Add(new string(chArr1));
                        queue.Enqueue(new char[] { chArr1[0], chArr1[1], chArr1[2], chArr1[3] });
                        queuenum.Enqueue(num);
                    }

                }


                for (int i = 0; i < 4; i++)
                {
                    char[] chArr2 = new string(chArr).ToCharArray();
                    if (chArr2[i] == '0')
                    {
                        chArr2[i] = '9';
                    }
                    else
                    {
                        chArr2[i]--;
                    }
                    if (new string(chArr2) == target)
                    {
                        return num;
                    }
                    else if (!set.Contains(new string(chArr2)) && !checker.Contains(new string(chArr2)))
                    {
                        checker.Add(new string(chArr2));
                        queue.Enqueue(new char[] { chArr2[0], chArr2[1], chArr2[2], chArr2[3] });
                        queuenum.Enqueue(num);
                    }


                }


            }

            return -1;
        }
    }
}