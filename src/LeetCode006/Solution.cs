using System.Collections.Generic;
using System.Text;

namespace LeetCode006
{
    public class Solution
    {
        public enum Direction
        {
            Down,
            Up
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var rows = new List<char>[numRows];
            for (var i = 0; i < numRows; i++)
            {
                rows[i] = new List<char>();
            }

            var direction = Direction.Down;
            var length = s.Length;
            var row = 0;
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                rows[row].Add(c);

                if (direction == Direction.Down)
                {
                    if (row == numRows - 1)
                    {
                        row--;
                        direction = Direction.Up;
                    }
                    else
                    {
                        row++;
                    }
                }
                else
                {
                    if (row == 0)
                    {
                        row++;
                        direction = Direction.Down;
                    }
                    else
                    {
                        row--;
                    }
                }
            }

            var result = new StringBuilder();
            foreach (var chars in rows)
            {
                foreach (var c in chars)
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
