namespace LeetCode2086
{
    public class Solution
    {
        public int MinimumBuckets(string street)
        {
            var result = 0;

            var streetArray = street.ToCharArray();
            var length = streetArray.Length;
            for (var i = 0; i < length; i++)
            {
                var c = streetArray[i];
                if (c != 'H')
                {
                    continue;
                }

                // 第一个字符
                if (i == 0)
                {
                    if (length <= 1 ||// 整个字符串只有一个 H
                        streetArray[1] == 'H')// 第二个字符是 H
                    {
                        return -1;
                    }

                    // 将水桶放到第二个字符的地方
                    streetArray[1] = 'B';
                    result++;
                }
                // 最后一个字符
                else if (i == length - 1)
                {
                    var previous = streetArray[i - 1];
                    if (previous == 'H')// 倒数第二个字符是 H
                    {
                        return -1;
                    }

                    if (previous == 'B')
                    {
                        // 前一个已经是水桶，不做处理
                        continue;
                    }

                    // 前一个是点，放置水桶
                    streetArray[i - 1] = 'B';
                    result++;
                }
                else
                {
                    var previous = streetArray[i - 1];
                    if (previous == 'B')
                    {
                        // 前一个已经是水桶，不做处理
                        continue;
                    }

                    var next = streetArray[i + 1];
                    if (next == 'H')
                    {
                        // 后一个是 H，水桶只能放到前面

                        if (previous == 'H')
                        {
                            return -1;
                        }

                        // 水桶放到前一个
                        streetArray[i - 1] = 'B';
                        result++;
                    }
                    else
                    {
                        // 后一个是 .，水桶放到后面去
                        streetArray[i + 1] = 'B';
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
