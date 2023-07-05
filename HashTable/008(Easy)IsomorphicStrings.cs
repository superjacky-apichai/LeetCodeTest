using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"
Output: true
Example 2:

Input: s = "foo", t = "bar"
Output: false
Example 3:

Input: s = "paper", t = "title"
Output: true
 

Constraints:

1 <= s.length <= 5 * 104
t.length == s.length
s and t consist of any valid ascii character.*/
namespace HashTable
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            char[] sCh = s.ToCharArray();
            char[] tCh = t.ToCharArray();
            Dictionary<char, char> sKeyTValue = new Dictionary<char, char>();
            Dictionary<char, char> tKeySValue = new Dictionary<char, char>();

            for (int i = 0; i < sCh.Length; i++)
            {
                if (sKeyTValue.ContainsKey(sCh[i])&&sKeyTValue[sCh[i]] != tCh[i])
                {
                    
            
                        return false;
                    

                }
                else if (tKeySValue.ContainsKey(tCh[i])&&tKeySValue[tCh[i]] != sCh[i])
                {
                    
                    
                        return false;
                    
                }
              
                tKeySValue[tCh[i]] = sCh[i];
                sKeyTValue[sCh[i]] = tCh[i];
            }
            return true;
        }
    }
}