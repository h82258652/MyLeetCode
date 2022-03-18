namespace LeetCode2043
{
    public class Bank
    {
        private readonly long[] _balance;

        public Bank(long[] balance)
        {
            _balance = balance;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if (account1 <= 0 || account1 > _balance.Length ||
                account2 <= 0 || account2 > _balance.Length)
            {
                return false;
            }

            var account1CurrentMoney = _balance[account1 - 1];
            if (account1CurrentMoney < money)
            {
                return false;
            }

            _balance[account1 - 1] = account1CurrentMoney - money;
            _balance[account2 - 1] += money;
            return true;
        }

        public bool Deposit(int account, long money)
        {
            if (account <= 0 || account > _balance.Length)
            {
                return false;
            }

            _balance[account - 1] += money;
            return true;
        }

        public bool Withdraw(int account, long money)
        {
            if (account <= 0 || account > _balance.Length)
            {
                return false;
            }

            var currentMoney = _balance[account - 1];
            if (currentMoney < money)
            {
                return false;
            }

            _balance[account - 1] = currentMoney - money;
            return true;
        }
    }
}
