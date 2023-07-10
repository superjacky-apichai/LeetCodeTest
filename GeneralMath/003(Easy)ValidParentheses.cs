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
            Dictionary<char, char> dict2 = new Dictionary<char, char>();
            dict2[')'] = '(';
            dict2['}'] = '{';
            dict2[']'] = '[';
            char[] chArr = s.ToCharArray();
            if (chArr.Length < 2)
            {

                return false;

            }
            else if (chArr.Length == 2)
            {

                return dict.ContainsKey(chArr[0]) && dict[chArr[0]] == chArr[1];
            }
            else if (chArr.Length % 2 != 0)
            {

                return false;
            }

            IList<char> set = new List<char>();

            for (int i = 0; i < chArr.Length; i++)
            {
                if (dict.ContainsKey(chArr[i]))
                {

                    set.Add(chArr[i]);
                }
                else if (dict2.ContainsKey(chArr[i]))
                {
                    
                    if (set.Count == 0)
                    {
                        return false;
                    }
                    else if (!set.Contains(dict2[chArr[i]]))
                    {
                        return false;
                    }
                    else
                    {
                        if (set.ElementAt(set.Count - 1) == dict2[chArr[i]])
                        {
                            set.RemoveAt(set.Count - 1);
                            continue;
                        }
                       
                        return false;
                    }
                }

            }

            if(set.Count != 0){
                return false;
            }
            return true;
        }
    }
}