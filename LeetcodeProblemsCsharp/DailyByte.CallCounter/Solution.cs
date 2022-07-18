/*
 * This question is asked by Google. Create a class CallCounter that tracks the number of calls a client has made within the last 3 seconds. 
 * Your class should contain one method, ping(int t) that receives the current timestamp (in milliseconds) of a new call being made and returns the number of calls made within the last 3 seconds.
 * Note: you may assume that the time associated with each subsequent call to ping is strictly increasing.
 * 
 * Ex: Given the following calls to ping…
 * 
 * ping(1), return 1 (1 call within the last 3 seconds)
 * ping(300), return 2 (2 calls within the last 3 seconds)
 * ping(3000), return 3 (3 calls within the last 3 seconds)
 * ping(3002), return 3 (3 calls within the last 3 seconds)
 * ping(7000), return 1 (1 call within the last 3 seconds)
 */
public static class Solution
{
    public class CallCounter
    {
        private List<int> _pings;

        public CallCounter()
        {
            _pings = new List<int>();
        }

        public int ping(int t)
        {
            _pings.Add(t);

            return _pings.Where(x => x > t - 3000)
                .Count();
        }

        public int pingv2(int t)
        {
            _pings.Add(t);

            // Update to remove anything below the dif
            var diff = t - 3000;

            _pings.RemoveRange(0, _pings.Where(x => x < diff).Count());

            return _pings.Count();
        }
    }

    public static void Examples()
    {
        var c = new CallCounter();
        Console.WriteLine(c.ping(1));
        Console.WriteLine(c.ping(300));
        Console.WriteLine(c.ping(3000));
        Console.WriteLine(c.ping(3002));
        Console.WriteLine(c.ping(7000));
    }

    public static void ExamplesV2()
    {
        var c = new CallCounter();
        Console.WriteLine(c.pingv2(1));
        Console.WriteLine(c.pingv2(300));
        Console.WriteLine(c.pingv2(3000));
        Console.WriteLine(c.pingv2(3002));
        Console.WriteLine(c.pingv2(7000));
    }
}