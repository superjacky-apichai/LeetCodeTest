using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a singly linked list, reverse the list, and return the reversed list.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?*/
namespace LinkedList
{
    /**
  Definition for singly-linked list.*/
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

    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode reverse = null;
            ListNode temp = head;

            while (temp != null)
            {
                ListNode next = temp.next;
                temp.next = reverse;
                reverse = temp;
                temp = next;
            }

            return reverse;

        }



    }


}
