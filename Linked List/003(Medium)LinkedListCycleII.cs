using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.

Do not modify the linked list.

 

Example 1:


Input: head = [3,2,0,-4], pos = 1
Output: tail connects to node index 1
Explanation: There is a cycle in the linked list, where tail connects to the second node.
Example 2:


Input: head = [1,2], pos = 0
Output: tail connects to node index 0
Explanation: There is a cycle in the linked list, where tail connects to the first node.
Example 3:


Input: head = [1], pos = -1
Output: no cycle
Explanation: There is no cycle in the linked list.
 

Constraints:

The number of the nodes in the list is in the range [0, 104].
-105 <= Node.val <= 105
pos is -1 or a valid index in the linked-list.
 

Follow up: Can you solve it using O(1) (i.e. constant) memory?*/
namespace LinkedList
{
    public class LinkedListCycleII
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }

            public ListNode DetectCycle(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return null;
                }
                ListNode slow = head;
                ListNode fast = head.next;
                int countSlow = 0;
                int countFast = 1;

                while (fast.next != null && fast.next.next != null)
                {

                    if (slow.next == fast.next.next)
                    {
                       int count =1;
                       slow = slow.next;
                       while(slow != fast){
                        slow= slow.next;
                        count++;
                       }
                        return fast;
                    }
                    slow = slow.next;
                    countSlow++;
                    fast = fast.next.next;
                    countFast+=2;

                }

                return null;


            }
        }




    }
}