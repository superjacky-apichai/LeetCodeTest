using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Replace Elements with Greatest Element on Right Side
Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.

After doing so, return the array.

 

Example 1:

Input: arr = [17,18,5,4,6,1]
Output: [18,6,6,6,1,-1]
Explanation: 
- index 0 --> the greatest element to the right of index 0 is index 1 (18).
- index 1 --> the greatest element to the right of index 1 is index 4 (6).
- index 2 --> the greatest element to the right of index 2 is index 4 (6).
- index 3 --> the greatest element to the right of index 3 is index 4 (6).
- index 4 --> the greatest element to the right of index 4 is index 5 (1).
- index 5 --> there are no elements to the right of index 5, so we put -1.
Example 2:

Input: arr = [400]
Output: [-1]
Explanation: There are no elements to the right of index 0.
 

Constraints:

1 <= arr.length <= 104
1 <= arr[i] <= 105

*/

namespace Array
{
    public class ReplaceElementswithGreatestElementonRightSide
    {

        public static void main(string[] args)
        {
            Console.WriteLine(ReplaceElements(new int[] { 15, 2, 3, 4, 5, 6, 7, 8, 9 }));

        }


        public static int[] ReplaceElements(int[] arr)
        {

            int[] arr2 = arr;
            int backup = 0;
            if (arr2.Length == 1)
            {
                return new int[] { -1 };
            }
            else if (arr2.Length == 2)
            {
                backup = arr2[arr2.Length - 2];
                arr2[arr2.Length - 2] = arr2[arr2.Length - 1];
                arr2[arr2.Length - 1] = -1;

                return arr2;
            }
            else
            {
                int[] arr3 = new int[arr2.Length + 1];
                for (int i = 0; i < arr2.Length; i++)
                {

                    arr3[i] = arr2[i];
                }
            
                backup = 0;
                arr3[arr3.Length - 1] = -1;
                for (int i = arr3.Length-2; i >= 0; i--)
                {
                    if (backup > arr3[i])
                    {
                        arr3[i] = backup;
                    }
                    else
                    {
                        backup = arr3[i];
                    }
                }
                for (int i = arr2.Length - 1; i >= 0; i--)
                {
                    arr2[i] = arr3[i + 1];
                }

            }

            return arr2;
        }

    }
}