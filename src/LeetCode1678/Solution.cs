using System.Text;

namespace LeetCode1678
{
    public class Solution
    {
        public string Interpret(string command)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < command.Length; i++)
            {
                var c = command[i];
                if (c == 'G')
                {
                    builder.Append('G');
                }
                else
                {
                    if (command[i + 1] == ')')
                    {
                        builder.Append('o');
                        i++;
                    }
                    else
                    {
                        builder.Append("al");
                        i += 3;
                    }
                }
            }

            return builder.ToString();
        }
    }
}
