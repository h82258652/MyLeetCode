using System.Collections.Generic;
using System.Linq;

namespace LeetCode682
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            var points = new List<int>();
            foreach (var op in ops)
            {
                switch (op)
                {
                    case "+":
                        points.Add(points[points.Count - 1] + points[points.Count - 2]);
                        break;
                    case "D":
                        points.Add(points[points.Count - 1] * 2);
                        break;
                    case "C":
                        points.RemoveAt(points.Count - 1);
                        break;
                    default:
                        points.Add(int.Parse(op));
                        break;
                }
            }

            return points.Sum();
        }
    }
}
