using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

The first node is considered odd, and the second node is even, and so on.

Note that the relative order inside both the even and odd groups should remain as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time complexity.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]
Example 2:


Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]
 

Constraints:

The number of nodes in the linked list is in the range [0, 104].
-106 <= Node.val <= 106*/
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
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {

            if (head == null)
            {
                return null;
            }
            else if (head.next == null)
            {
                return head;
            }
            else if (head.next.next == null)
            {
                return head;
            }

            ListNode temp = head;
            ListNode evenNode = temp.next;
            temp.next = evenNode.next;
            temp = temp.next;
            evenNode.next = null;
            ListNode evenTemp = evenNode;
            while (temp != null && temp.next != null)
            {

                evenTemp.next = temp.next;
                evenTemp = evenTemp.next;
                if (evenTemp.next == null)
                {
                    break;
                }
                temp.next = evenTemp.next;
                temp = temp.next;
                evenTemp.next = null;


            }



            temp.next = evenNode;
            evenNode = null;
            evenTemp= null;
            temp=null;



            return head;
        }
    }
}