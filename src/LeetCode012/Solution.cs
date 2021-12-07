using System.Text;

namespace LeetCode012
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var result = new StringBuilder();

            while (num > 0)
            {
                if (num >= 1000)
                {
                    result.Append('M');
                    num -= 1000;
                    continue;
                }

                if (num >= 900)
                {
                    result.Append("CM");
                    num -= 900;
                    continue;
                }

                if (num >= 500)
                {
                    result.Append('D');
                    num -= 500;
                    continue;
                }

                if (num >= 400)
                {
                    result.Append("CD");
                    num -= 400;
                    continue;
                }

                if (num >= 100)
                {
                    result.Append('C');
                    num -= 100;
                    continue;
                }

                if (num >= 90)
                {
                    result.Append("XC");
                    num -= 90;
                    continue;
                }

                if (num >= 50)
                {
                    result.Append('L');
                    num -= 50;
                    continue;
                }

                if (num >= 40)
                {
                    result.Append("XL");
                    num -= 40;
                    continue;
                }

                if (num >= 10)
                {
                    result.Append('X');
                    num -= 10;
                    continue;
                }

                if (num >= 9)
                {
                    result.Append("IX");
                    num -= 9;
                    continue;
                }

                if (num >= 5)
                {
                    result.Append('V');
                    num -= 5;
                    continue;
                }

                if (num >= 4)
                {
                    result.Append("IV");
                    num -= 4;
                    continue;
                }

                result.Append('I', num);
                break;
            }

            return result.ToString();
        }
    }
}
