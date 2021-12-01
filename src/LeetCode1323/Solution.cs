namespace LeetCode1323
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var charArray = num.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                if (c == '6')
                {
                    charArray[i] = '9';
                    break;
                }
            }

            return int.Parse(new string(charArray));
        }
    }
}
