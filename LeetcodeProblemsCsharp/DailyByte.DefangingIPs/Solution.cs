/*
 * This question is asked by Amazon. Given a valid IP address, defang it.
 * Note: To defang an IP address, replace every ”.”, with ”[.]”.
 * 
 * Ex: Given the following address…
 * address = "127.0.0.1", return "127[.]0[.]0[.]1"
 */

public static class Solution
{
    public static string Defang(string ip)
    {
        if (string.IsNullOrWhiteSpace(ip)) return string.Empty;
        if (!ip.Contains('.')) return string.Empty;

        return ip.Replace(".", "[.]");
    }

    public static void Examples()
    {
        var exs = new List<string>
        {
            "127.0.0.1",
            "255.255.255.255",
            "123.456.789"
        };

        foreach (var ex in exs)
        {
            Console.WriteLine($"{ex} -> {Defang(ex)}");
        }
    }
}
