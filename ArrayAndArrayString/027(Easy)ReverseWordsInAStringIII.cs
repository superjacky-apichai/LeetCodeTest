using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Example 2:

Input: s = "God Ding"
Output: "doG gniD"
 

Constraints:

1 <= s.length <= 5 * 104
s contains printable ASCII characters.
s does not contain any leading or trailing spaces.
There is at least one word in s.
All the words in s are separated by a single space.*/
namespace ArrayAndArrayString
{
    public class ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            string[] resArr = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string res = "";

            for (int i = 0; i < resArr.Length; i++)
            {
                char[] reverse = resArr[i].ToCharArray();
                Console.Write(reverse[i]);
                Array.Reverse(reverse);
                res +=new string(reverse.ToString())+" ";

            }

            return res.Trim();

        }

    }
}