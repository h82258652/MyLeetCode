using System.Collections.Generic;

namespace JianZhi09
{
    /// <summary>
    /// 空间复杂度 O(n)
    /// </summary>
    public class CQueue
    {
        private readonly Stack<int> _frontStack;
        private readonly Stack<int> _backStack;

        public CQueue()
        {
            _frontStack = new Stack<int>();
            _backStack = new Stack<int>();
        }

        /// <summary>
        /// 时间复杂度 O(n)，n 为当前元素数量
        /// </summary>
        /// <param name="value"></param>
        public void AppendTail(int value)
        {
            // 后退栈有值的话，先将后退栈的元素都放回前进栈
            while (_backStack.Count > 0)
            {
                _frontStack.Push(_backStack.Pop());
            }

            _frontStack.Push(value);
        }

        /// <summary>
        /// 时间复杂度 O(n)，因为要从前进栈倒过来放进后退栈
        /// </summary>
        /// <returns></returns>
        public int DeleteHead()
        {
            // 后退栈有值的话，说明上一次操作是 DeleteHead 且有元素剩余
            if (_backStack.Count > 0)
            {
                return _backStack.Pop();
            }

            // 后退栈为空且前进栈为空，说明没有元素
            if (_frontStack.Count <= 0)
            {
                return -1;
            }

            // 将前进栈的元素反向放进后退栈
            while (_frontStack.Count > 0)
            {
                _backStack.Push(_frontStack.Pop());
            }

            return _backStack.Pop();
        }
    }
}
