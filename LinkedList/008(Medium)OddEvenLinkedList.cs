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