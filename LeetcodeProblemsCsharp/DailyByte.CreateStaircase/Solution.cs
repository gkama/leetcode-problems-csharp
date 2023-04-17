/*
 * Given a value, N, you are asked to form a staircase. The number of elements in each row of the staircase must match the current row. Return the total number of full staircase rows you can create.
 * 
 * Ex: Given the following N...
 * N = 3 return 2.
 * *
 * * * (this staircase has two rows)
 * 
 * Ex: Given the following N...
 * N = 7 return 3.
 * *
 * * *
 * * * *
 * * (this row is not full)
 */
public static class Solution
{
    public static void CreateStaircase(int n)
    {
        if (n == 0) return;

        var count = 1;
        var staircases = 0;

        Console.WriteLine($"N = {n}");
        while (n >= count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            n = n - count;
            count++;
            staircases++;
        }

        if (n > 0)
        {
            for (var i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Staircases: {staircases}");
        Console.WriteLine();
    }

    public static void Examples()
    {
        var exs = new List<int>
        {
            1,
            3,
            7,
            15,
            16
        };

        foreach (var ex in exs)
        {
            CreateStaircase(ex);
        }
    }
}