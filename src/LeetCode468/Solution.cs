namespace LeetCode468
{
    public class Solution
    {
        public string ValidIPAddress(string queryIP)
        {
            var ipV4 = queryIP.Split('.');
            if (ipV4.Length == 4)
            {
                if (IsIPv4Part(ipV4[0]) &&
                    IsIPv4Part(ipV4[1]) &&
                    IsIPv4Part(ipV4[2]) &&
                    IsIPv4Part(ipV4[3]))
                {
                    return "IPv4";
                }
            }

            var ipV6 = queryIP.Split(':');
            if (ipV6.Length == 8)
            {
                if (IsIPv6Part(ipV6[0]) &&
                    IsIPv6Part(ipV6[1]) &&
                    IsIPv6Part(ipV6[2]) &&
                    IsIPv6Part(ipV6[3]) &&
                    IsIPv6Part(ipV6[4]) &&
                    IsIPv6Part(ipV6[5]) &&
                    IsIPv6Part(ipV6[6]) &&
                    IsIPv6Part(ipV6[7]))
                {
                    return "IPv6";
                }
            }

            return "Neither";
        }

        private bool IsIPv6Part(string part)
        {
            if (part.Length < 1 || part.Length > 4)
            {
                return false;
            }

            foreach (var c in part)
            {
                if (char.IsDigit(c))
                {
                    continue;
                }
                else if (c >= 'a' && c <= 'f')
                {
                    continue;
                }
                else if (c >= 'A' && c <= 'F')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsIPv4Part(string part)
        {
            if (part != "0" && part.StartsWith('0'))
            {
                return false;
            }

            if (int.TryParse(part, out var ipV4Part))
            {
                if (ipV4Part >= 0 && ipV4Part <= 255)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
