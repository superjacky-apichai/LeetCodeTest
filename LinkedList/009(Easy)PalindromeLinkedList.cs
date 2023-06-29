using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

 

Example 1:


Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9
 

Follow up: Could you do it in O(n) time and O(1) space?*/
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
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> vals = new List<int>();

            ListNode temp = head;
            while (temp != null)
            {
                vals.Add(temp.val);

                temp = temp.next;
            }

            int front = 0;
            int back = vals.Count() - 1;

            while (front < back)
            {

                if (vals.ElementAt(front) != vals.ElementAt(back))
                {
                    return false;
                }

                front++;
                back--;
            }

            return true;
        }
    }
}