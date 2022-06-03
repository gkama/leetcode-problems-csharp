/*
 * Depth first search
 * Uses a stack
 * 
 * given this graph
 *          A
 *        /   \
 *       B     C   
 *      / \   / \
 *     D   E F   G
 * find a value (for example "E")
 */
public static class Dfs
{
    public static HashSet<string> SearchWithSample(string start, string value)
    {
        var vertices = new[] { "A", "B", "C", "D", "E", "F", "G" };
        var edges = new[] { Tuple.Create("A", "C"), Tuple.Create("A", "B"),
                Tuple.Create("B", "E"), Tuple.Create("B", "D"),
                Tuple.Create("C", "G"), Tuple.Create("C", "F") };

        var graph = new Graph(vertices, edges);

        return Search(graph, start, value);
    }

    // Iterative
    private static HashSet<string> Search(Graph graph, string start, string value)
    {
        var explored = new HashSet<string>();

        if (!graph.AdjacencyList.ContainsKey(start))
            return explored;

        var stack = new Stack<string>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            var vertex = stack.Pop();

            if (vertex == value)
            {
                return explored;
            }

            if (explored.Contains(vertex))
            {
                continue;
            }

            explored.Add(vertex);

            foreach (var neighbor in graph.AdjacencyList[vertex])
            {
                if (!explored.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
        }

        return explored;
    }
}

class Graph
{
    public Dictionary<string, HashSet<string>> AdjacencyList { get; } = new Dictionary<string, HashSet<string>>();

    public Graph() { }
    public Graph(IEnumerable<string> vertices, IEnumerable<Tuple<string, string>> edges)
    {
        foreach (var vertex in vertices)
        {
            AddVertex(vertex);
        }

        foreach (var edge in edges)
        {
            AddEdge(edge);
        }
    }

    public void AddVertex(string vertex)
    {
        AdjacencyList[vertex] = new HashSet<string>();
    }

    public void AddEdge(Tuple<string, string> edge)
    {
        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
        {
            AdjacencyList[edge.Item1].Add(edge.Item2);
            AdjacencyList[edge.Item2].Add(edge.Item1);
        }
    }
}
