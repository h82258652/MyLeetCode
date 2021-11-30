namespace LeetCode605
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var length = flowerbed.Length;

            int previous = 0;
            for (var i = 0; i < length; i++)
            {
                var bed = flowerbed[i];
                if (bed == 1 || previous == 1)
                {
                    previous = bed;
                    continue;
                }

                if (i < length - 1)
                {
                    var nextBed = flowerbed[i + 1];
                    if (nextBed == 1)
                    {
                        previous = nextBed;
                        i++;
                        continue;
                    }
                    else
                    {
                        flowerbed[i] = 1;
                        n--;
                        previous = 1;
                    }
                }
                else
                {
                    n--;
                }

                if (n <= 0)
                {
                    break;
                }
            }

            return n <= 0;
        }
    }
}
