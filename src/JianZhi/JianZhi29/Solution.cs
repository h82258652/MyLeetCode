using System;

namespace JianZhi29
{
    public class Solution
    {
        public enum Direction
        {
            Right = 0,
            Bottom = 1,
            Left = 2,
            Top = 3
        }

        /// <summary>
        /// 时间复杂度 O(mn)，m、n分别为matrix的宽高
        /// 空间复杂度 O(1)，返回数组不算在内
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int[] SpiralOrder(int[][] matrix)
        {
            var height = matrix.Length;
            if (height <= 0)
            {
                return Array.Empty<int>();
            }

            var width = matrix[0].Length;
            if (width <= 0)
            {
                return Array.Empty<int>();
            }

            var rightEdge = width - 1;
            var bottomEdge = height - 1;
            var leftEdge = 0;
            var topEdge = 0;
            var i = 0;
            var j = 0;
            var direction = Direction.Right;

            var resultCount = width * height;
            var resultIndex = 0;
            var result = new int[resultCount];

            while (resultIndex < resultCount)
            {
                if (direction == Direction.Right)
                {
                    if (i < rightEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        i++;
                    }
                    else if (i == rightEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        j++;
                        topEdge++;
                        direction = Direction.Bottom;
                    }
                }
                else if (direction == Direction.Bottom)
                {
                    if (j < bottomEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        j++;
                    }
                    else if (j == bottomEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        i--;
                        rightEdge--;
                        direction = Direction.Left;
                    }
                }
                else if (direction == Direction.Left)
                {
                    if (i > leftEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        i--;
                    }
                    else if (i == leftEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        j--;
                        bottomEdge--;
                        direction = Direction.Top;
                    }
                }
                else if (direction == Direction.Top)
                {
                    if (j > topEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        j--;
                    }
                    else if (j == topEdge)
                    {
                        result[resultIndex] = matrix[j][i];
                        resultIndex++;
                        i++;
                        leftEdge++;
                        direction = Direction.Right;
                    }
                }
            }

            return result;
        }
    }
}
