using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Design your implementation of the linked list. You can choose to use a singly or doubly linked list.
A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node.
If you want to use the doubly linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.

Implement the MyLinkedList class:

MyLinkedList() Initializes the MyLinkedList object.
int get(int index) Get the value of the indexth node in the linked list. If the index is invalid, return -1.
void addAtHead(int val) Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
void addAtTail(int val) Append a node of value val as the last element of the linked list.
void addAtIndex(int index, int val) Add a node of value val before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, the node will not be inserted.
void deleteAtIndex(int index) Delete the indexth node in the linked list, if the index is valid.
 

Example 1:

Input
["MyLinkedList", "addAtHead", "addAtTail", "addAtIndex", "get", "deleteAtIndex", "get"]
[[], [1], [3], [1, 2], [1], [1], [1]]
Output
[null, null, null, null, 2, null, 3]

Explanation
MyLinkedList myLinkedList = new MyLinkedList();
myLinkedList.addAtHead(1);
myLinkedList.addAtTail(3);
myLinkedList.addAtIndex(1, 2);    // linked list becomes 1->2->3
myLinkedList.get(1);              // return 2
myLinkedList.deleteAtIndex(1);    // now the linked list is 1->3
myLinkedList.get(1);              // return 3
 

Constraints:

0 <= index, val <= 1000
Please do not use the built-in LinkedList library.
At most 2000 calls will be made to get, addAtHead, addAtTail, addAtIndex and deleteAtIndex.*/
namespace LinkedList
{
    public class DesignLinkedList
    {


        public class MyLinkedList
        {

            public class Node
            {
                public int val;
                public Node next;

                public Node(int val)
                {
                    this.val = val;
                    this.next = null;
                }
            }
            Node head;

            public MyLinkedList()
            {

            }

            public Node FindIndex(int index)
            {
                if (index == 0)
                {
                    return head != null ? head : null;
                }
                Node temp = head;
                int count = 0;
                if (temp == null)
                {
                    return null;
                }

                while (temp.next != null)
                {
                    temp = temp.next;
                    count++;
                    if (index == count)
                    {
                        return temp;
                    }
                }

                return null;

            }

            public int Get(int index)
            {
                return FindIndex(index) != null ? FindIndex(index).val : -1;
            }

            public void AddAtHead(int val)
            {
                Node newNode = new Node(val);
                if (head == null)
                {
                    head = newNode;
                    return;
                }

                newNode.next = head;
                head = newNode;

            }

            public void AddAtTail(int val)
            {

                if (head == null)
                {
                    AddAtHead(val);
                    return;
                }
                Node newNode = new Node(val);
                newNode.next = null;
                Node lastNode = FindLastNode();
                lastNode.next = newNode;
            }

            public Node FindLastNode()
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            public void AddAtIndex(int index, int val)
            {
                if (index == 0)
                {
                    AddAtHead(val);
                    return;
                }

                Node curNode = FindIndex(index - 1);
                if (curNode == null)
                {
                    return;
                }

                Node newNode = new Node(val);
                newNode.next = curNode.next;
                curNode.next = newNode;


            }

            public void DeleteAtIndex(int index)
            {
                if (index == 0)
                {
                    if (head.next != null)
                    {
                        head = head.next;
                        return;
                    }
                    head = null;
                    return;

                }
                Node prev = FindIndex(index - 1);
                Node cur = FindIndex(index);

                if (cur == null)
                {
                    return;
                }
                prev.next = cur.next;
                cur.next = null;
                cur = null;
            }
        }



    }
}


/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
