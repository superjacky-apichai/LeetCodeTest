using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given two binary strings a and b, return their sum as a binary string.

 

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
 

Constraints:

1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.*/
namespace ArrayAndArrayString
{
    public class AddBinary
    {
        public string AddBinary(string a, string b)
        {
            char[] charA = a.Length >= b.Length ? a.ToCharArray() : b.ToCharArray();
            char[] charB = b.Length <= a.Length ? b.ToCharArray() : a.ToCharArray();
            List<char> res = new List<char>();
            int backup = 0;
            int count = charB.Length-1;
            
           
            for (int i = charA.Length-1; i >=0; i--)
            {
                if (count ==-1)
                {
                    if (charA[i] == '0' && backup > 0)
                    {
                        res.Add('1');
                        backup--;
                        continue;
                    }
                    else if (charA[i] == '0' && backup < 1)
                    {
                        res.Add('0');
                        continue;
                    }
                    else if (charA[i] == '1' && backup > 0)
                    {
                        res.Add('0');
                        continue;
                    }
                    else if (charA[i] == '1' && backup < 1)
                    {
                        res.Add('1');
                        continue;
                    }
                }
                else
                {

                    if (((charB[count] == '1' && charA[i] == '0') || (charB[count] == '0' && charA[i] == '1')) && backup > 0)
                    {

                        res.Add('0');
                        backup = 1;
                        count--;
                        continue;
                    }
                    else if (((charB[count] == '1' && charA[i] == '0') || (charB[count] == '0' && charA[i] == '1')) && backup < 1)
                    {

                        res.Add('1');

                        count--;
                        continue;
                    }
                    else if (charB[count] == '1' && charA[i] == '1' && backup < 1)
                    {


                        backup = 1;
                        res.Add('0');
                        count--;
                        continue;
                    }
                    else if (charB[count] == '1' && charA[i] == '1' && backup > 0)
                    {

                        backup = 1;
                        res.Add('1');
                        count--;
                        continue;
                    }
                    else if (charB[count] == '0' && charA[i] == '0' && backup > 0)
                    {

                        backup--;
                        res.Add('1');
                        count--;
                        continue;

                    }
                    else if (charB[count] == '0' && charA[i] == '0')
                    {

                        res.Add('0');
                        count--;
                        continue;

                    }
                }



            }

            if (backup > 0)
            {
                res.Add('1');
            }
            res.Reverse();
            return String.Join("", res);
        }





    }

}
