namespace MainShiTi0105
{
    public class Solution
    {
        public bool OneEditAway(string first, string second)
        {
            if (first == second)
            {
                return true;
            }

            if (first.Length == second.Length)
            {
                var misMatch = false;
                for (var i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        if (misMatch)
                        {
                            return false;
                        }

                        misMatch = true;
                    }
                }

                return true;
            }
            else
            {
                string longer;
                string shorter;
                if (first.Length > second.Length)
                {
                    longer = first;
                    shorter = second;
                }
                else
                {
                    longer = second;
                    shorter = first;
                }

                if (longer.Length - shorter.Length > 1)
                {
                    return false;
                }

                var misMatch = false;

                for (int i = 0, j = 0; i < longer.Length && j < shorter.Length;)
                {
                    if (longer[i] == shorter[j])
                    {
                        i++;
                        j++;
                        continue;
                    }

                    if (misMatch)
                    {
                        return false;
                    }

                    misMatch = true;
                    i++;
                }

                return true;
            }
        }
    }
}
