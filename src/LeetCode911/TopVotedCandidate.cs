using System;
using System.Collections.Generic;

namespace LeetCode911
{
    public class TopVotedCandidate
    {
        private readonly int _length;
        private readonly int[] _times;
        private readonly Dictionary<int, int> _winPersonAtTime;

        public TopVotedCandidate(int[] persons, int[] times)
        {
            _times = times;
            _length = times.Length;

            _winPersonAtTime = new Dictionary<int, int>();// 某个时间点赢了的人
            var personTicketCount = new Dictionary<int, int>();// 某个候选人的当前票数

            var max = -1;// 当前最大票数
            var lastWinPerson = -1;// 前一个时间点获胜的人

            for (var i = 0; i < _length; i++)
            {
                // 更新当前候选人获得的票数
                var person = persons[i];
                personTicketCount.TryGetValue(person, out var count);
                count++;
                personTicketCount[person] = count;

                // 如果当前候选人获得的票数大于等于当前票数，则此刻的时间点这个候选人获胜
                var time = _times[i];
                if (count >= max)
                {
                    lastWinPerson = person;
                    max = count;

                    _winPersonAtTime[time] = person;
                }
                else
                {
                    _winPersonAtTime[time] = lastWinPerson;
                }
            }
        }

        public int Q(int t)
        {
            for (var i = _length - 1; i >= 0; i--)
            {
                // 查找在此时间当前或者前一个时间点获胜的人
                var time = _times[i];
                if (time <= t)
                {
                    return _winPersonAtTime[time];
                }
            }

            throw new InvalidOperationException();
        }
    }
}
