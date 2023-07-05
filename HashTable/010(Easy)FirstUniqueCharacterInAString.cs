using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

 

Example 1:

Input: s = "leetcode"
Output: 0
Example 2:

Input: s = "loveleetcode"
Output: 2
Example 3:

Input: s = "aabb"
Output: -1
 

Constraints:

1 <= s.length <= 105
s consists of only lowercase English letters.*/
namespace HashTable
{
    public class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            Char[] sCh = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < sCh.Length; i++)
            {
                if (dict.ContainsKey(sCh[i]))
                {
                    dict[sCh[i]] = int.MaxValue;
                    continue;
                }
                dict[sCh[i]] = i;
            }
            int res = int.MaxValue;
            foreach (int i in dict.Values)
            {
                if (res > i)
                {
                    res = i;
                }
            }

            return res == int.MaxValue ? -1 : res;
        }

    }
}