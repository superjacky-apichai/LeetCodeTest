using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,1,2]
Output: [1,2]
Example 2:


Input: head = [1,1,2,3,3]
Output: [1,2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.*/
namespace GeneralMath
{
    // Definition for singly-linked list.
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
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {

            ListNode temp = head;
            while (temp != null)
            {
                ListNode temp1 = temp;
                while (temp1.next != null)
                {
                    if (temp1.next.val == temp.val)
                    {

                        temp1.next = temp1.next.next;
                        continue;

                    }

                    if (temp1.next != null)
                    {
                        temp1 = temp1.next;
                    }

                }
                temp = temp.next;
            }


            return head;
        }

    }
}