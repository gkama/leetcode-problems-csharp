/*
 * Design a class to implement a stack using only a single queue. 
 * Your class, QueueStack, should support the following stack methods: push() (adding an item), 
 * pop() (removing an item), 
 * peek() (returning the top value without removing it), 
 * and empty() (whether or not the stack is empty).
 */
public static class Solution
{
    public class QueueStack
    {
        private readonly Queue<int> _queue;

        public QueueStack()
        {
            _queue = new Queue<int>();
        }

        public void Push(int num)
        {
            _queue.Enqueue(num);
        }

        public int Pop()
        {
            var items = new List<int>();
            var num = 0;

            while (_queue.Count() > 0)
            {
                var item = _queue.Dequeue();

                if (_queue.Count() == 0)
                {
                    num = item;
                }
                else
                {
                    items.Add(item);
                }
            }

            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }

            return num;
        }

        public int Peek()
        {
            var items = new List<int>();
            var num = 0;

            while (_queue.Count() > 0)
            {
                var item = _queue.Dequeue();

                if (_queue.Count() == 1)
                {
                    num = _queue.Peek();
                    items.Add(item);
                }
                else
                {
                    items.Add(item);
                }
            }

            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }

            return num;
        }

        public bool Empty()
        {
            return _queue.Count() == 0;
        }
    }

    public static void Examples()
    {
        var qs = new QueueStack();

        qs.Push(1);
        qs.Push(2);
        qs.Push(3);
        Console.WriteLine(qs.Peek());   // 3
        Console.WriteLine(qs.Pop());    // 3
        Console.WriteLine(qs.Peek());   // 2
        qs.Push(3);
        Console.WriteLine(qs.Pop());    // 3
        Console.WriteLine(qs.Peek());   // 2
        Console.WriteLine(qs.Empty());  // false
        Console.WriteLine(qs.Pop());    // 2
        Console.WriteLine(qs.Pop());    // 1
        Console.WriteLine(qs.Empty());  // true
    }
}
