using System.Collections.Generic;

namespace LeetCode729
{
    public class MyCalendar
    {
        private readonly List<MyBook> _myBooks = new List<MyBook>();

        public class MyBook
        {
            public MyBook(int start, int end)
            {
                Start = start;
                End = end;
            }

            public int Start { get; }

            public int End { get; }
        }

        public MyCalendar()
        {
        }

        public bool Book(int start, int end)
        {
            foreach (var book in _myBooks)
            {
                if (end > book.Start && start < book.End)
                {
                    return false;
                }
            }

            _myBooks.Add(new MyBook(start, end));
            return true;
        }
    }
}
