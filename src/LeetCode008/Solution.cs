namespace LeetCode008
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            var result = 0;

            var sign = 0;// 正负，1代表>=0，0代表>=0，-1代表<0
            var started = false;// 是否已经开始计算，用于忽略前导零
            var digitStarted = false;
            var length = s.Length;
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                if (c == ' ')
                {
                    if (!started)
                    {
                        continue;
                    }

                    break;
                }

                started = true;
                if (c == '+')
                {
                    if (digitStarted)
                    {
                        break;
                    }

                    if (sign != 0)
                    {
                        break;
                    }

                    sign = 1;
                }
                else if (c == '-')
                {
                    if (digitStarted)
                    {
                        break;
                    }

                    if (sign != 0)
                    {
                        break;
                    }

                    sign = -1;
                }
                else if (char.IsDigit(c))
                {
                    digitStarted = true;

                    // check overflow
                    if (sign == 0 || sign == 1)
                    {
                        if (result > int.MaxValue / 10)
                        {
                            return int.MaxValue;
                        }
                    }
                    else
                    {
                        if (result < int.MinValue / 10)
                        {
                            return int.MinValue;
                        }
                    }

                    result *= 10;

                    var plus = c - '0';

                    // check overflow
                    if (sign == 0 || sign == 1)
                    {
                        if (result > int.MaxValue - plus)
                        {
                            return int.MaxValue;
                        }

                        result += plus;
                    }
                    else
                    {
                        if (result < int.MinValue + plus)
                        {
                            return int.MinValue;
                        }

                        result -= plus;
                    }
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
