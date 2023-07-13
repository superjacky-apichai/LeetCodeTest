using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralMath
{
    public class LengthofLastWord
    {
        public int LengthOfLastWord(string s) {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            return words[words.Length-1].Length;
        
    } 
    }
}