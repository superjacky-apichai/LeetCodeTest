using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a linked list, rotate the list to the right by k places.

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2


Input: head = [0,1,2], k = 4
Output: [2,0,1]
 

Constraints:

The number of nodes in the list is in the range [0, 500].
-100 <= Node.val <= 100
0 <= k <= 2 * 109*/
namespace LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        publicListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return head;
            }
            int size = k % FindIndex(head);
            if (size == 0)
            {
                return head;
            }
            else if (head.next == null)
            {
                return head;
            }
            else if (head.next.next == null)
            {
                if (size == 1)
                {
                    head.next.next = head;
                    head = head.next;
                    head.next.next = null;
                    return head;
                }

                return head;

            }

            while (size != 0)
            {
                ListNode temp = FindBeforeLastIndex(head);
                ListNode temp1 = temp.next;
                temp.next = null;
                temp1.next = head;
                head = temp1;
                size--;
            }





            return head;
        }

        public int FindIndex(ListNode node)
        {
            ListNode Temp = node;
            int count = 1;

            while (Temp.next != null)
            {
                Temp = Temp.next;
                count++;
            }

            return count;

        }
        public ListNode FindBeforeLastIndex(ListNode node)
        {
            ListNode temp = node;

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            return temp;

        }
    }
}