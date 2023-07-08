using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashTable
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int cout = 0;
            HashSet<char> jewSet = new HashSet<string>();
            char[] jew = jewels.ToArray();
            jewSet.UnionWith(jew);

            char[] stone = stones.ToCharArray();

            foreach(char i in stone){
                if(jewSet.Contains(i)){

                    cout++;
                }
            }
          



         return cout;
        }

    }
}