using System;

namespace LeetCode832
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (var i = 0; i < image.Length; i++)
            {
                Array.Reverse(image[i]);
            }

            for (var i = 0; i < image.Length; i++)
            {
                for (var j = 0; j < image[i].Length; j++)
                {
                    image[i][j] = 1 - image[i][j];
                }
            }

            return image;
        }
    }
}
