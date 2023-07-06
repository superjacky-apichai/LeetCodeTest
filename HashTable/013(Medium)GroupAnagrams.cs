using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.*/
namespace HashTable
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = getKeyAndValue(strs);
            IList<IList<string>> res = new List<IList<string>>();
            

            foreach (var i in dict)
            {
                res.Add(i.Value);
                

            }

            return res;
        }


        public Dictionary<string, IList<string>> getKeyAndValue(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chArray = strs[i].ToCharArray();
                Array.Sort(chArray);
                string toStr = new string(chArray);
                if (!dict.ContainsKey(toStr))
                {
                    dict[toStr] = new List<string>();
                }
                dict[toStr].Add(strs[i]);
                
            }

            return dict;
        }
    }
}