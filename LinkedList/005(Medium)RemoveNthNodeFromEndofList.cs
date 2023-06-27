using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
 

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz
 

Follow up: Could you do this in one pass?*/
namespace LinkedList
{
    /**
 * Definition for singly-linked list.*/
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


    public class RemoveNthNodeFromEndofList
    {

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 1;
            ListNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
                count++;
            }
            temp = null;
            if (count == 1 && n == 1)
            {

                head = null;

            }
            else if (count == 2)
            {
                if (n == 2)
                {
                    head = head.next;
                }
                else if (n == 1)
                {
                    head.next = null;
                }
            }
            else
            {

                ListNode slow = head;
                ListNode fast = head;
                int count1 = 1;
                int rescount = Math.Abs(count - (n - 1));
                Console.Write(rescount);
                if (rescount == 1)
                {
                    head = head.next;
                }
                else
                {
                    while (count1 < rescount)
                    {

                        slow = fast;
                        fast = fast.next;

                        count1++;

                    }
                    fast = fast.next;
                    slow.next = fast;
                    fast = null;
                    slow = null;
                }
            }
            return head;

        }

    }
}