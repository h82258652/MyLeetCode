using System;
using System.Collections.Generic;

namespace LeetCode735
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var list = new List<int>(asteroids);
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    continue;
                }

                if (i <= 0)
                {
                    continue;
                }

                if (list[i - 1] > 0)
                {
                    var abs = Math.Abs(list[i]);
                    if (list[i - 1] > abs)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                    else if (list[i - 1] == abs)
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(i - 1);
                        i -= 2;
                    }
                    else
                    {
                        list.RemoveAt(i - 1);
                        i -= 2;
                    }
                }
            }

            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] < 0)
                {
                    continue;
                }

                if (i >= list.Count - 1)
                {
                    continue;
                }

                if (list[i + 1] < 0)
                {
                    var abs = Math.Abs(list[i + 1]);
                    if (list[i] > abs)
                    {
                        list.RemoveAt(i + 1);
                    }
                    else if (list[i] == abs)
                    {
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i);
                    }
                    else
                    {
                        list.RemoveAt(i);
                    }
                }
            }

            return list.ToArray();
        }
    }
}
