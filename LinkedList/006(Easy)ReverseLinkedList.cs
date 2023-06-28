using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
