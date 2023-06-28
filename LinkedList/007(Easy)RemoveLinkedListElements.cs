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