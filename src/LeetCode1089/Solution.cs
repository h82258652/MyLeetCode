namespace LeetCode1089
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            var length = arr.Length;
            for (var i = 0; i < length; i++)
            {
                var num = arr[i];
                if (num != 0)
                {
                    continue;
                }

                MoveElements(arr, i + 1, length);
                if (i + 1 < length)
                {
                    arr[i + 1] = 0;
                }
                i++;
            }
        }

        private void MoveElements(int[] nums, int start, int length)
        {
            for (var i = length - 1; i >= start; i--)
            {
                nums[i] = nums[i - 1];
            }
        }
    }
}
