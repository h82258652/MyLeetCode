using System.Collections.Generic;
using System.Text;

namespace LeetCode929
{
    public class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var processedEmails = new HashSet<string>();
            foreach (var email in emails)
            {
                processedEmails.Add(Process(email));
            }

            return processedEmails.Count;
        }

        private string Process(string email)
        {
            var temp = email.Split('@');
            var local = temp[0];
            var domain = temp[1];
            var builder = new StringBuilder();
            foreach (var c in local)
            {
                if (c == '+')
                {
                    break;
                }

                if (c == '.')
                {
                    continue;
                }

                builder.Append(c);
            }

            return builder.ToString() + "@" + domain;
        }
    }
}
