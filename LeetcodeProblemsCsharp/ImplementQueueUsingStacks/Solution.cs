// https://leetcode.com/problems/implement-queue-using-stacks/
public static class Solution
{
    /*
     * Alg
     *  only using 2 stacks
     *  if you have 1 stack with [1, 2, 3]
     *  pop it [3, 2, 1] 
     *  then you pop again, that's a queue
     *  before you do an operation, you transfer from one stack to the other
     */
    public class MyQueue
    {
        private Stack<int> _left;
        private Stack<int> _right;

        public MyQueue()
        {
            _left = new Stack<int>();
            _right = new Stack<int>();
        }

        public void Push(int x)
        {
            _left.Push(x);
        }

        public int Pop()
        {
            while (_left.Count() > 0)
            {
                _right.Push(_left.Pop());
            }

            var top = _right.Pop();

            while (_right.Count() > 0)
            {
                _left.Push(_right.Pop());
            }

            return top;
        }

        public int Peek()
        {
            while (_left.Count() > 0)
            {
                _right.Push(_left.Pop());
            }

            var top = _right.Peek();

            while (_right.Count() > 0)
            {
                _left.Push(_right.Pop());
            }

            return top;
        }

        public bool Empty()
        {
            return _left.Count() == 0;
        }
    }
}