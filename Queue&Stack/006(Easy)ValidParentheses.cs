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
namespace QueueStack
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }
            else if (s.Length == 1)
            {
                return false;
            }
            char[] ch = s.ToCharArray();
            Stack<char> stack1 = new Stack<char>();

            for (int i = 0; i < ch.Length; i++)
            {
                switch (ch[i])
                {
                    case '(':
                        stack1.Push(ch[i]);
                        break;
                    case '{':
                        stack1.Push(ch[i]);
                        break;
                    case '[':
                        stack1.Push(ch[i]);
                        break;
                    case ')':
                        if (stack1.Count == 0)
                        {
                            return false;
                        }
                        else if (stack1.Peek() != '(')
                        {
                            return false;
                        }
                        else
                        {
                            stack1.Pop();
                        }
                        break;
                    case ']':
                        if (stack1.Count == 0)
                        {
                            return false;
                        }
                        else if (stack1.Peek() != '[')
                        {
                            return false;
                        }
                        else
                        {
                            stack1.Pop();
                        }
                        break;
                    case '}':
                        if (stack1.Count == 0)
                        {
                            return false;
                        }
                        else if (stack1.Peek() != '{')
                        {
                            return false;
                        }
                        else
                        {
                            stack1.Pop();
                        }
                        break;
                    default:
                        return false;
                        break;

                }
            }

            if (stack1.Count > 0)
            {
                return false;
            }

            return true;

        }
    }
}