using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralMath
{
    /*Given an integer x, return true if x is a 
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
 

Follow up: Could you solve it without converting the integer to a string?*/
    public class IsPalindrome
    {
        public bool IsPalindrome(int x)
        {
            if(x <0){
            return false;
            }
            int backupX = x;
            int reverse =0;
            while(backupX>0){
                sum *= 10;
                int temp = backupX % 10;
                sum += temp;
                backupX /= 10;
            }


            return sum == x; 

        }
    }
}