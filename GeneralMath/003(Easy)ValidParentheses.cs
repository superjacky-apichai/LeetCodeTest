using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.*/
namespace GeneralMath
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['{'] = '}';
            dict['['] = ']';
            char[] chArr = s.ToCharArray();
            if (chArr.Length < 2)
            {

                return false;

            }
            else if (chArr.Length == 2)
            {

                return dict.ContainsKey(chArr[0]) && dict[chArr[0]] == chArr[1];
            }
            bool finding = false;
            for (int i = 0; i < chArr.Length - 1; i++)
            {
                if (dict.ContainsKey(chArr[i]))
                {
                    for (int j = i + 1; j < chArr.Length; j++)
                    {
                        if (dict[chArr[i]] == chArr[j])
                        {
                            chArr[j] = '.';
                            finding = true;
                            break;
                        }
                    }

                    if (!finding)
                    {
                        return false;
                    }

                    finding = false;
                    continue;
                }else if(!dict.ContainsKey(chArr[i])&&chArr[i]!= '.'){
                    return false;
                }
                


            }
            return true;
        }
    }
}