using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

The test cases are generated so that the length of the output will never exceed 105.

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"
Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"
Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
 

Constraints:

1 <= s.length <= 30
s consists of lowercase English letters, digits, and square brackets '[]'.
s is guaranteed to be a valid input.
All the integers in s are in the range [1, 300].


Test case
"3[a]2[bc]"
"3[a2[c]]"
"2[abc]3[cd]ef"
"3[a2[bc2[bc]]2[fg]rt]"
"fr3[a2[bc2[bc]]2[fg]rt]df"

*/
namespace QueueStack
{
    public class DecodeString
    {
        public string DecodeString(string s)
        {
            Stack<string> queueCh = new Stack<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) == ']')
                {
                    string dumplicate = "";

                    while (queueCh.Count > 0)
                    {

                        if (queueCh.Peek() == "[")
                        {
                            queueCh.Pop();
                            string checkNum = "";


                            while (queueCh.Count > 0)
                            {
                                if (!int.TryParse(queueCh.Peek(), out _))
                                {
                                    break;
                                }
                                checkNum = queueCh.Pop() + checkNum;
                            }

                            int count = int.Parse(checkNum);
                            string FindAlphabet = "";
                            while (count > 0)
                            {
                                FindAlphabet = dumplicate + FindAlphabet;
                                count--;
                            }
                            queueCh.Push(FindAlphabet);
                            break;

                        }
                        dumplicate = queueCh.Pop() + dumplicate;
                    }

                    continue;
                }

                queueCh.Push(s.ElementAt(i).ToString());

            }


            string res = "";
            while (queueCh.Count > 0)
            {
                res = queueCh.Pop() + res;
            }

            return res;
        }

    }
}