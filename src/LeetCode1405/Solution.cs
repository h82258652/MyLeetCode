using System;
using System.Text;

namespace LeetCode1405
{
    public class Solution
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            var builder = new StringBuilder();

            Do(a, b, c, builder);

            return builder.ToString();
        }

        private void Do(int a, int b, int c, StringBuilder builder)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                return;
            }

            if (a == 0 && b == 0)
            {
                builder.Append(new string('c', Math.Min(c, 2)));
                return;
            }

            if (a == 0 && c == 0)
            {
                builder.Append(new string('b', Math.Min(b, 2)));
                return;
            }

            if (b == 0 && c == 0)
            {
                builder.Append(new string('a', Math.Min(a, 2)));
                return;
            }

            if (builder.Length == 0)
            {
                if (a >= b && a >= c)
                {
                    var aCount = Math.Min(a, 2);
                    builder.Append(new string('a', aCount));
                    Do(a - aCount, b, c, builder);
                    return;
                }
                else if (b >= a && b >= c)
                {
                    var bCount = Math.Min(b, 2);
                    builder.Append(new string('b', bCount));
                    Do(a, b - bCount, c, builder);
                    return;
                }
                else
                {
                    var cCount = Math.Min(c, 2);
                    builder.Append(new string('c', cCount));
                    Do(a, b, c - cCount, builder);
                    return;
                }
            }
            else
            {
                var last = builder[builder.Length - 1];
                if (last == 'a')
                {
                    if (b >= c)
                    {
                        if (b >= a)
                        {
                            if (b == 1)
                            {
                                builder.Append("b");
                                Do(a, b - 1, c, builder);
                                return;
                            }
                            else if (b > 1)
                            {
                                builder.Append("bb");
                                Do(a, b - 2, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (b > 0)
                            {
                                builder.Append("b");
                                Do(a, b - 1, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (c >= a)
                        {
                            if (c == 1)
                            {
                                builder.Append("c");
                                Do(a, b, c - 1, builder);
                                return;
                            }
                            else if (c > 1)
                            {
                                builder.Append("cc");
                                Do(a, b, c - 2, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (c > 0)
                            {
                                builder.Append("c");
                                Do(a, b, c - 1, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else if (last == 'b')
                {
                    if (a >= c)
                    {
                        if (a >= b)
                        {
                            if (a == 1)
                            {
                                builder.Append("a");
                                Do(a - 1, b, c, builder);
                                return;
                            }
                            else if (a > 1)
                            {
                                builder.Append("aa");
                                Do(a - 2, b, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (a > 0)
                            {
                                builder.Append("a");
                                Do(a - 1, b, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (c >= b)
                        {
                            if (c == 1)
                            {
                                builder.Append("c");
                                Do(a, b, c - 1, builder);
                                return;
                            }
                            else if (c > 1)
                            {
                                builder.Append("cc");
                                Do(a, b, c - 2, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (c > 0)
                            {
                                builder.Append("c");
                                Do(a, b, c - 1, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else
                {
                    if (a >= b)
                    {
                        if (a >= c)
                        {
                            if (a == 1)
                            {
                                builder.Append("a");
                                Do(a - 1, b, c, builder);
                                return;
                            }
                            else if (a > 1)
                            {
                                builder.Append("aa");
                                Do(a - 2, b, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (a > 0)
                            {
                                builder.Append("a");
                                Do(a - 1, b, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (b >= c)
                        {
                            if (b == 1)
                            {
                                builder.Append("b");
                                Do(a, b - 1, c, builder);
                                return;
                            }
                            else if (b > 1)
                            {
                                builder.Append("bb");
                                Do(a, b - 2, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (b > 0)
                            {
                                builder.Append("b");
                                Do(a, b - 1, c, builder);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
