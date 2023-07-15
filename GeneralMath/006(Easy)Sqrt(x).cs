using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*69. Sqrt(x)
Easy
6.8K
4.2K
Companies
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 

Example 1:

Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.
Example 2:

Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
 

Constraints:

0 <= x <= 231 - 1*/
namespace GeneralMath
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            long count = 0;
            if (x >= 1000 && x < 10000)
            {
                count = 10;
            }
            else if (x >= 10000 && x < 1000000)
            {
                count = 100;
            }
            else if (x >= 1000000 && x < 100000000)
            {
                count = 1000;
            }
            else if (x >= 100000000 && x < 10000000000)
            {
                count = 10000;
            }
            else if (x >= 10000000000)
            {
                count = 100000;
            }

            while (true)
            {

                if (count * count > x)
                {
                    while (true)
                    {
                        if (count * count <= x)
                        {
                            return (int)count;
                        }
                       count--;
                    }

                }

                count += 10;
            }
            return -1;
        }
    }
}