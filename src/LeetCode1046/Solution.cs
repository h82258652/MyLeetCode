using System.Collections.Generic;

namespace LeetCode1046
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            var queue = new PriorityQueue<int, int>();
            foreach (var stone in stones)
            {
                queue.Enqueue(stone, -stone);
            }

            while (queue.Count > 1)
            {
                var y = queue.Dequeue();
                var x = queue.Dequeue();
                if (y - x != 0)
                {
                    queue.Enqueue(y - x, -(y - x));
                }
            }

            if (queue.Count == 0)
            {
                return 0;
            }

            return queue.Peek();
        }
    }
}
