using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.*/
namespace LinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode newNode = new ListNode(0);

            ListNode newTemp = newNode;
            int count = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    int sum = l1.val + l2.val;
                    sum += count;
                    count = 0;
                    if (sum >= 10)
                    {
                        count = sum / 10;
                        sum -= 10;
                    }
                    newTemp.next = new ListNode(sum);
                    newTemp = newTemp.next;


                }
                else if (l1 != null)
                {

                    int sum = l1.val + count;
                    count = 0;
                    if (sum >= 10)
                    {
                        count = sum / 10;
                        sum -= 10;
                    }
                    newTemp.next = new ListNode(sum);
                    newTemp = newTemp.next;

                }
                else if (l2 != null)
                {
                    int sum = l2.val + count;
                    count = 0;
                    if (sum >= 10)
                    {
                        count = sum / 10;
                        sum -= 10;
                    }
                    newTemp.next = new ListNode(sum);
                    newTemp = newTemp.next;
                }
                
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (count > 0)
            {
                newTemp.next = new ListNode(1);
            }
            newNode = newNode.next;
            return newNode;

        }
    }
}