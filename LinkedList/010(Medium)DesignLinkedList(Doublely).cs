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
            public class doubleNode
            {
                public int val;
                public doubleNode prev;
                public doubleNode next;

                public doubleNode(int val)
                {
                    this.val = val;
                    prev = null;
                    next = null;
                }
            }

            public doubleNode head;
            public MyLinkedList()
            {
            }

            public doubleNode FindByIndex(int index)
            {
                doubleNode temp = head;
                int findIndex = 0;

                while (temp != null)
                {

                    if (findIndex == index)
                    {
                        break;
                    }
                    temp = temp.next;
                    findIndex++;
                }

                return temp != null ? temp : null;
            }

            public int Get(int index)
            {


                return FindByIndex(index) != null ? FindByIndex(index).val : -1;
            }

            public void AddAtHead(int val)
            {
                doubleNode newNode = new doubleNode(val);
                if (head == null)
                {
                    head = newNode;
                    return;
                }

                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }

            public void AddAtTail(int val)
            {
                doubleNode newNode = new doubleNode(val);
                if (head == null)
                {
                    head = newNode;
                    return;
                }

                doubleNode temp = FindLastIndex();

                newNode.prev = temp;
                temp.next = newNode;

            }

            public doubleNode FindLastIndex()
            {
                doubleNode temp = head;

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
                doubleNode findNode = FindByIndex(index);

                if (findNode == null && FindByIndex(index - 1) != null)
                {
                    AddAtTail(val);
                    return;
                }
                else if (findNode == null && FindByIndex(index - 1) == null)
                {
                    return;
                }
                doubleNode newNode = new doubleNode(val);
                newNode.prev = findNode.prev;
                findNode.prev.next = newNode;
                findNode.prev = newNode;
                newNode.next = findNode;


            }

            public void DeleteAtIndex(int index)
            {
                if (index == 0)
                {
                    if (head.next != null)
                    {
                        head = head.next;
                        head.prev = null;

                        return;
                    }

                    head = null;
                    return;
                }

                doubleNode findNode = FindByIndex(index);
                if (findNode == null)
                {
                    return;
                }
                doubleNode prev = findNode.prev;
                doubleNode next = findNode.next;
                prev.next = next;
                if (next != null)
                {
                    next.prev = prev;
                }



            }

        }
    }
}