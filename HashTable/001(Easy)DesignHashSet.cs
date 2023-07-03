using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Design HashSet
Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
 

Example 1:

Input
["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
[[], [1], [2], [1], [3], [2], [2], [2], [2]]
Output
[null, null, null, true, false, null, true, null, false]

Explanation
MyHashSet myHashSet = new MyHashSet();
myHashSet.add(1);      // set = [1]
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(1); // return True
myHashSet.contains(3); // return False, (not found)
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(2); // return True
myHashSet.remove(2);   // set = [1]
myHashSet.contains(2); // return False, (already removed)
 

Constraints:

0 <= key <= 106
At most 104 calls will be made to add, remove, and contains.*/
namespace HashTable
{
    public class DesignHashSet
    {
        public class Node
        {
            public int val;
            public Node next;

            public Node(int val)
            {
                this.val = val;
            }
        }

        public class MyHashSet
        {
            private readonly int MaxLen = 10000;
            private Node[] Set;

            public MyHashSet()
            {
                this.Set = new Node[MaxLen];
            }

            public int getIndex(int key)
            {
                return key % MaxLen;
            }

            public void Add(int key)
            {
                int index = getIndex(key);
                if (Contains(key))
                {
                    return;
                }
                Node newNode = new Node(key);
                if (Set[index] == null)
                {
                    Set[index] = newNode;
                    return;
                }
                newNode.next = Set[index];
                Set[index] = newNode;


            }

            public void Remove(int key)
            {

                int index = getIndex(key);

                if (Set[index] == null)
                {
                    return;
                }
                else if (Set[index].val == key)
                {
                    if (Set[index].next == null)
                    {
                        Set[index] = null;
                        return;
                    }
                    Set[index] = Set[index].next;
                    return;
                }

                Node temp = Set[index];
                while (temp.next != null)
                {
                    if (temp.next.val == key)
                    {
                        temp.next = temp.next.next;
                        return;
                    }
                    temp = temp.next;
                }
            }

            public bool Contains(int key)
            {
                int index = getIndex(key);
                if (Set[index] == null)
                {
                    return false;
                }
                Node temp = Set[index];
                while (temp != null)
                {

                    if (temp.val == key)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
        }
    }
}