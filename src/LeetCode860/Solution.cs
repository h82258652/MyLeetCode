namespace LeetCode860
{
    public class Solution
    {
        public bool LemonadeChange(int[] bills)
        {
            var fiveCount = 0;
            var tenCount = 0;

            var length = bills.Length;
            for (var i = 0; i < length; i++)
            {
                var bill = bills[i];
                switch (bill)
                {
                    case 5:
                        fiveCount++;
                        break;

                    case 10:
                        if (fiveCount <= 0)
                        {
                            return false;
                        }

                        fiveCount--;
                        tenCount++;
                        break;

                    case 20:

                        if (tenCount > 0)
                        {
                            if (fiveCount <= 0)
                            {
                                return false;
                            }

                            tenCount--;
                            fiveCount--;
                        }
                        else
                        {
                            if (fiveCount <= 2)
                            {
                                return false;
                            }

                            fiveCount -= 3;
                        }

                        break;
                }
            }

            return true;
        }
    }
}
