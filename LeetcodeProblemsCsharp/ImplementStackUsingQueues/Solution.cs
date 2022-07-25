// https://leetcode.com/problems/implement-stack-using-queues/
public class MyStack
{

    private Queue<int> _queue1;
    private Queue<int> _queue2;

    public MyStack()
    {
        _queue1 = new Queue<int>();
        _queue2 = new Queue<int>();
    }

    public void Push(int x)
    {
        _queue1.Enqueue(x);
    }

    public int Pop()
    {
        if (_queue1.Count() > 0) return PopQueue1();
        else if (_queue2.Count() > 0) return PopQueue2();

        return 0;
    }

    public int Top()
    {
        if (_queue1.Count() > 0) return TopQueue1();
        else if (_queue2.Count() > 0) return TopQueue2();

        return 0;
    }

    // Pop
    private int PopQueue1()
    {
        while (_queue1.Count() > 0)
        {
            var value = _queue1.Dequeue();

            if (_queue1.Count() == 0)
            {
                return value;
            }
            else
            {
                _queue2.Enqueue(value);
            }
        }

        return 0;
    }
    private int PopQueue2()
    {
        while (_queue2.Count() > 0)
        {
            var value = _queue2.Dequeue();

            if (_queue2.Count() == 0)
            {
                return value;
            }
            else
            {
                _queue1.Enqueue(value);
            }
        }

        return 0;
    }

    // Top
    private int TopQueue1()
    {
        while (_queue1.Count() > 0)
        {
            var value = _queue1.Dequeue();

            _queue2.Enqueue(value);

            if (_queue1.Count() == 0)
            {
                return value;
            }
        }

        return 0;
    }
    private int TopQueue2()
    {
        while (_queue2.Count() > 0)
        {
            var value = _queue2.Dequeue();

            _queue1.Enqueue(value);

            if (_queue2.Count() == 0)
            {
                return value;
            }
        }

        return 0;
    }

    public bool Empty()
    {
        return _queue1.Count() == 0 && _queue2.Count() == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */