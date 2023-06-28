using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            ListNode evenNode = head.next;
            int count = 0;



            return evenNode;
        }
    }
}