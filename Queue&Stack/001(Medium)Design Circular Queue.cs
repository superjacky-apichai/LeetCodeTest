using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
Design your implementation of the circular queue. The circular queue is a linear data structure in which the operations are performed based on FIFO (First In First Out) principle, and the last position is connected back to the first position to make a circle. It is also called "Ring Buffer".

One of the benefits of the circular queue is that we can make use of the spaces in front of the queue. In a normal queue, once the queue becomes full, we cannot insert the next element even if there is a space in front of the queue. But using the circular queue, we can use the space to store new values.

Implement the MyCircularQueue class:

MyCircularQueue(k) Initializes the object with the size of the queue to be k.
int Front() Gets the front item from the queue. If the queue is empty, return -1.
int Rear() Gets the last item from the queue. If the queue is empty, return -1.
boolean enQueue(int value) Inserts an element into the circular queue. Return true if the operation is successful.
boolean deQueue() Deletes an element from the circular queue. Return true if the operation is successful.
boolean isEmpty() Checks whether the circular queue is empty or not.
boolean isFull() Checks whether the circular queue is full or not.
You must solve the problem without using the built-in queue data structure in your programming language. 

 

Example 1:

Input
["MyCircularQueue", "enQueue", "enQueue", "enQueue", "enQueue", "Rear", "isFull", "deQueue", "enQueue", "Rear"]
[[3], [1], [2], [3], [4], [], [], [], [4], []]
Output
[null, true, true, true, false, 3, true, true, true, 4]

Explanation
MyCircularQueue myCircularQueue = new MyCircularQueue(3);
myCircularQueue.enQueue(1); // return True
myCircularQueue.enQueue(2); // return True
myCircularQueue.enQueue(3); // return True
myCircularQueue.enQueue(4); // return False
myCircularQueue.Rear();     // return 3
myCircularQueue.isFull();   // return True
myCircularQueue.deQueue();  // return True
myCircularQueue.enQueue(4); // return True
myCircularQueue.Rear();     // return 4
 

Constraints:

1 <= k <= 1000
0 <= value <= 1000
At most 3000 calls will be made to enQueue, deQueue, Front, Rear, isEmpty, and isFull.



Test case
["MyCircularQueue","enQueue","Rear","Rear","deQueue","enQueue","Rear","deQueue","Front","deQueue","deQueue","deQueue"]
[[6],[6],[],[],[],[5],[],[],[],[],[],[]]

["MyCircularQueue","enQueue","Rear","Rear","deQueue","enQueue","Rear","deQueue","Front","deQueue","deQueue","deQueue"]
[[6],[6],[],[],[],[5],[],[],[],[],[],[]]


*/
namespace QueueStack
{


    public class MyCircularQueue
    {
        int[] QueueArr;
        int FrontArr;
        int RearArr;


        public MyCircularQueue(int k)
        {
            this.QueueArr = new int[k];
            this.FrontArr = -1;
            this.RearArr = -1;

        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return false;
            }

            if (IsEmpty())
            {
                this.FrontArr = 0;
            }
            this.RearArr = (this.RearArr + 1) % this.QueueArr.Length;
            this.QueueArr[this.RearArr] = value;
            Console.WriteLine("Enqueued: " + value);
            return true;

        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty. Cannot dequeue.");
                return false;
            }
            int dequeueItem = this.QueueArr[this.FrontArr];
            if (this.FrontArr == this.RearArr)
            {
                this.FrontArr = -1;
                this.RearArr = -1;


            }
            else
            {

                this.FrontArr = (this.FrontArr + 1) % this.QueueArr.Length;

            }

            Console.WriteLine("Dequeue: " + dequeueItem);
            return true;
        }

        public int Front()
        {
            return this.FrontArr == -1 ? -1 : this.QueueArr[this.FrontArr];
        }

        public int Rear()
        {
            return this.RearArr == -1 ? -1 : this.QueueArr[this.RearArr];
        }

        public bool IsEmpty()
        {
            return this.FrontArr == -1;

        }

        public bool IsFull()
        {
            return (this.RearArr + 1) % this.QueueArr.Length == this.FrontArr;
        }
    }
    public class DesignCircularQueue
    {


    }
}