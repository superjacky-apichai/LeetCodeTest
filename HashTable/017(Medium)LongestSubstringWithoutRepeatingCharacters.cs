using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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