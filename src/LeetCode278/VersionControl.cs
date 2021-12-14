namespace LeetCode278
{
    public class VersionControl
    {
        private int _badVersion;

        protected bool IsBadVersion(int version)
        {
            return version >= _badVersion;
        }

        public static Solution New(int badVersion)
        {
            return new Solution
            {
                _badVersion = badVersion
            };
        }
    }
}
