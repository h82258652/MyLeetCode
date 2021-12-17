namespace LeetCode1518
{
    public class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            return InternalNumWaterBottles(numBottles, numExchange, 0);
        }

        private int InternalNumWaterBottles(int numBottles, int numExchange, int emptyBottles)
        {
            numBottles += emptyBottles / numExchange;// 将空瓶子换成瓶子
            emptyBottles %= numExchange;// 剩余不能换瓶子的空瓶子个数

            if (numBottles + emptyBottles < numExchange)// 剩下的瓶子数量不能再兑换了
            {
                return numBottles;
            }

            return numBottles + InternalNumWaterBottles(0, numExchange, numBottles + emptyBottles);
        }
    }
}
