namespace LeetCode013
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var result = 0;

            var length = s.Length;
            var lengthMinus1 = length - 1;
            for (byte i = 0; i < length;)
            {
                var c = s[i];
                switch (c)
                {
                    case 'I':
                        if (i < lengthMinus1)
                        {
                            switch (s[i + 1])
                            {
                                case 'V':
                                    result += 4;
                                    i += 2;
                                    continue;
                                case 'X':
                                    result += 9;
                                    i += 2;
                                    continue;
                            }
                        }

                        result++;
                        i++;
                        break;

                    case 'V':
                        result += 5;
                        i++;
                        break;

                    case 'X':
                        if (i < lengthMinus1)
                        {
                            switch (s[i + 1])
                            {
                                case 'L':
                                    result += 40;
                                    i += 2;
                                    continue;
                                case 'C':
                                    result += 90;
                                    i += 2;
                                    continue;
                            }
                        }

                        result += 10;
                        i++;
                        break;

                    case 'L':
                        result += 50;
                        i++;
                        break;

                    case 'C':
                        if (i < lengthMinus1)
                        {
                            switch (s[i + 1])
                            {
                                case 'D':
                                    result += 400;
                                    i += 2;
                                    continue;
                                case 'M':
                                    result += 900;
                                    i += 2;
                                    continue;
                            }
                        }

                        result += 100;
                        i++;
                        break;

                    case 'D':
                        result += 500;
                        i++;
                        break;

                    case 'M':
                        result += 1000;
                        i++;
                        break;
                }
            }

            return result;
        }
    }
}
