using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

 

Example 1:


Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
Example 3:

Input: head = [7,7,7,7], val = 7
Output: []
 

Constraints:

The number of nodes in the list is in the range [0, 104].
1 <= Node.val <= 50
0 <= val <= 50*/
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
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            else if (head.next == null)
            {
                if (head.val == val)
                {

                    return null;
                }
                else
                {
                    return head;
                }
            }
            else if (head.val == val)
            {

                while (head.val == val)
                {

                    if (head.next == null)
                    {
                        return null;
                    }
                    head = head.next;
                }

            }

            ListNode fast = head;
            ListNode slow = null;
            while (fast.next != null)
            {


                if (fast.next.val == val)
                {
                    ListNode temp = fast.next;

                    fast.next = temp.next;
                    continue;
                }

                fast = fast.next;


            }

            return head;

        }
    }
}