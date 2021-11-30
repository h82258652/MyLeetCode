using System;

namespace LeetCode1154
{
    public class Solution
    {
        public int DayOfYear(string date)
        {
            var year = int.Parse(date.Substring(0, 4));
            var month = int.Parse(date.Substring(5, 2));
            var day = int.Parse(date.Substring(8, 2));

            var result = day;

            for (var i = 1; i < month; i++)
            {
                result += GetDaysInMonth(year, i);
            }

            return result;
        }

        private int GetDaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 2:
                    return IsRunNian(year) ? 29 : 28;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                default:
                    throw new InvalidOperationException();
            }
        }

        private bool IsRunNian(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 100 == 0)
            {
                return false;
            }

            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
