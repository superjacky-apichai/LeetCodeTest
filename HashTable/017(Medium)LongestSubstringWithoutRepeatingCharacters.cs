using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given a string s, find the length of the longest substring without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.*/
namespace HashTable
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            IList<char> list = s.ToCharArray().ToList();
            HashSet<char> set = new HashSet<char>();
            int count = 0;
            int res = 0;
            int len = 0;

            for (int i = 0; i < list.Count; i++)
            {

                if (set.Contains(list.ElementAt(i)))
                {
                    if (res < count)
                    {
                        res = count;
                    }

                    while (set.Contains(list.ElementAt(i)))
                    {
                        set.Remove(list.ElementAt(len));
                        len++;
                        count--;


                    }
                }
                set.Add(list.ElementAt(i));
                count++;

            }

            return res < count ? count : res;

        }

    }
}