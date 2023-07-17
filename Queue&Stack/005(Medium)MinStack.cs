using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(int val) pushes the element val onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.

 

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2
 

Constraints:

-231 <= val <= 231 - 1
Methods pop, top and getMin operations will always be called on non-empty stacks.
At most 3 * 104 calls will be made to push, pop, top, and getMin.*/
namespace QueueStack
{
    public class MinStack
    {
        Stack<int> stack;
        Stack<int> stackMin;

        public MinStack()
        {
            this.stack = new Stack<int>();
            this.stackMin = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            if(stackMin.Count == 0){
                stackMin.Push(val);
            }else if (stackMin.Peek() > val)
            {
                while(minValue > val){
                    int temp = this.stackMin.Pop();
                }
            }
        }

        public void Pop()
        {
            if (List.Count == 0)
            {
                return;
            }

            return List.RemoveAt(List.Count - 1);
        }

        public int Top()
        {
            if (List.Count == 0)
            {
                return;
            }
            return List.ElementAt(List.Count - 1);
        }

        public int GetMin()
        {

        }

    }
}