using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 
Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.*/

namespace LinkedList
{
    public class MergeTwoSortedLists
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 != null && list2 == null)
            {
                return list1;

            }
            else if (list1 == null && list2 != null)
            {
                return list2;

            }
            ListNode temp = list1;
            while (temp.next != null)
            {
                temp = temp.next;

            }

            temp.next = list2;
            temp = null;

            ListNode newNode = new ListNode(int.MinValue);
            ListNode tempNew = newNode;


            while (list1 != null)
            {

                ListNode min = list1;
                list1 = list1.next;
                min.next = null;
                tempNew = newNode;
                while (tempNew != null)
                {

                    if (tempNew.next == null)
                    {
                        tempNew.next = min;
                        break;
                    }
                    else if (tempNew.next != null && tempNew.next.val >= min.val)
                    {
                        min.next = tempNew.next;
                        tempNew.next = min;
                        break;

                    }

                    tempNew = tempNew.next;
                }
            }


            newNode = newNode.next;
            return newNode;

        }

    }
}