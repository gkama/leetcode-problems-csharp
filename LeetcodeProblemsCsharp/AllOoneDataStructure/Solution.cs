// https://leetcode.com/problems/all-oone-data-structure/
public class AllOne
{
    /*
     * Alg
     *      needs to preserve the order
     */
    private readonly Dictionary<string, int> _keys;
    private string _highest;
    private string _lowest;

    public AllOne()
    {
        _keys = new Dictionary<string, int>();
        _highest = string.Empty;
        _lowest = string.Empty;
    }

    public void Inc(string key)
    {
        // Initial addition
        if (!_keys.ContainsKey(key))
        {
            _keys.Add(key, 1);

            if (_keys.Count() == 1)
            {
                _highest = key;
                _lowest = key;
            }
            else
            {
                _lowest = key;
            }
        }
        else
        {
            _keys[key] += 1;

            // Keep highest
            // Keep lowest
            _highest = _keys[key] > _keys[_highest]
                ? key
                : _highest;

            _lowest = _keys[key] <= _keys[_lowest]
                ? key
                : _lowest;
        }
    }

    public void Dec(string key)
    {
        if (!_keys.ContainsKey(key))
        {
            return;
        }

        _keys[key] -= 1;

        if (_keys[key] == 0)
        {
            _keys.Remove(key);
            _lowest = _keys.OrderByDescending(x => x.Value).First().Key;
        }
        else
        {
            // Keep highest
            // Keep lowest
            _lowest = _keys[key] < _keys[_lowest]
                ? key
                : _lowest;
        }
    }

    public string GetMaxKey()
    {
        return _highest;
    }

    public string GetMinKey()
    {
        return _lowest;
    }
}
