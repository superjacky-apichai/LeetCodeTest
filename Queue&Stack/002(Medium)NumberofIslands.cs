using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueStack
{
    public class NumberofIslands
    {
        public int NumIslands(char[][] grid)
        {
            Queue<int[]> myQueue = new Queue<int[]>();
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {

                        myQueue.Enqueue(new int[] { i, j });
                        grid[i][j] = '0';
                        while (myQueue.Count > 0)
                        {
                            if (myQueue.Peek()[0] + 1 < grid.Length)
                            {
                                if (grid[myQueue.Peek()[0] + 1][myQueue.Peek()[1]] == '1')
                                {
                                    grid[myQueue.Peek()[0] + 1][myQueue.Peek()[1]] = '0';
                                    myQueue.Enqueue(new int[] { myQueue.Peek()[0] + 1, myQueue.Peek()[1] });
                                }
                            }

                            if (myQueue.Peek()[1] + 1 < grid[i].Length)
                            {
                                if (grid[myQueue.Peek()[0]][myQueue.Peek()[1] + 1] == '1')
                                {
                                    grid[myQueue.Peek()[0]][myQueue.Peek()[1] + 1] = '0';
                                    myQueue.Enqueue(new int[] { myQueue.Peek()[0], myQueue.Peek()[1] + 1 });

                                }
                            }
                            if (myQueue.Peek()[0] - 1 >= 0 )
                            {
                                if (grid[myQueue.Peek()[0] - 1][myQueue.Peek()[1]] == '1')
                                {
                                    grid[myQueue.Peek()[0] - 1][myQueue.Peek()[1]] = '0';
                                    myQueue.Enqueue(new int[] { myQueue.Peek()[0] - 1, myQueue.Peek()[1] });

                                }
                            }

                            if (myQueue.Peek()[1] - 1 >= 0)
                            {
                                if (grid[myQueue.Peek()[0]][myQueue.Peek()[1] - 1] == '1')
                                {
                                    grid[myQueue.Peek()[0]][myQueue.Peek()[1] - 1] = '0';
                                    myQueue.Enqueue(new int[] { myQueue.Peek()[0], myQueue.Peek()[1] - 1 });

                                }
                            }

                            myQueue.Dequeue();

                        }
                        count++;
                    }
                }
            }



            return count;

        }
    }
}