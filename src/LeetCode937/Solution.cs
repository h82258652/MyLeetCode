using System.Collections.Generic;
using System.Linq;

namespace LeetCode937
{
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var result = new List<string>(logs.Length);

            var letterLogs = new List<LetterLog>();
            var digitLogs = new List<string>();

            foreach (var log in logs)
            {
                var spaceIndex = log.IndexOf(' ');
                if (!char.IsDigit(log[spaceIndex + 1]))
                {
                    var letterLog = new LetterLog(log, spaceIndex);
                    letterLogs.Add(letterLog);
                }
                else
                {
                    digitLogs.Add(log);
                }
            }

            foreach (var letterLog in letterLogs.OrderBy(temp => temp.Content).ThenBy(temp => temp.Identity))
            {
                result.Add(letterLog.Raw);
            }

            foreach (var digitLog in digitLogs)
            {
                result.Add(digitLog);
            }

            return result.ToArray();
        }

        public class LetterLog
        {
            public LetterLog(string raw, int spaceIndex)
            {
                Raw = raw;
                Identity = raw.Substring(0, spaceIndex);
                Content = raw.Substring(spaceIndex + 1);
            }

            public string Identity { get; set; }

            public string Raw { get; set; }

            public string Content { get; set; }
        }
    }
}
