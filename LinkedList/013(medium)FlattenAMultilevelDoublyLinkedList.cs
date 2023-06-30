using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{


    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;
    }

    public class FlattenAMultilevelDoublyLinkedList
    {
        public Node Flatten(Node head)
        {

            if (head == null)
            {
                return null;
            }

            ListNode temp = head;
            ListNode newNode = new ListNode(0);
            ListNode newTemp = newNode;


        }

    }
}