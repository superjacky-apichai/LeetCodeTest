using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.*/
namespace ArrayAndArrayString
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string res = "";
            char[] toCompare = strs[0].ToCharArray();
            bool isAllSame = true;

            for (int i = 0; i < toCompare.Length; i++)
            {

                for (int j = 1; j < strs.Length; j++)
                {
                    string inJ = strs[j];
                    if (i < inJ.Length)
                    {
                        if (!inJ[i].Equals(toCompare[i]))
                        {
                            isAllSame = false;
                            break;
                        }
                    }
                    else
                    {
                        isAllSame = false;
                        break;

                    }
                }

                if (!isAllSame)
                {
                    break;
                }
                else if (isAllSame)
                {
                    res += toCompare[i];
                }
            }

            return res;

        }

    }
}