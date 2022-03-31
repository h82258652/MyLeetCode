using System.Linq;

namespace LeetCode2103
{
    public class Solution
    {
        public int CountPoints(string rings)
        {
            var array = new int[10];

            for (var i = 0; i < rings.Length; i += 2)
            {
                var color = rings[i];
                var position = rings[i + 1];

                switch (color)
                {
                    case 'R':
                        array[position - '0'] |= 1;
                        break;

                    case 'G':
                        array[position - '0'] |= 2;
                        break;

                    case 'B':
                        array[position - '0'] |= 4;
                        break;
                }
            }

            return array.Count(temp => temp == 7);
        }
    }
}
