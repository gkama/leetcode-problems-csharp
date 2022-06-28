public class MyHashMap
{

    private List<MyHashMapItem> _myHashMapItems;

    public MyHashMap()
    {
        _myHashMapItems = new List<MyHashMapItem>();
    }

    public void Put(int key, int value)
    {
        var item = GetItem(key);

        if (item == null) // doesn't exist
        {
            _myHashMapItems.Add(
                new MyHashMapItem
                {
                    Key = key,
                    Value = value
                });
        }
        else // exists
        {
            item.Value = value;
        }
    }

    public int Get(int key)
    {
        var item = GetItem(key);

        if (item == null) // doesn't exist
        {
            return -1;
        }
        else
        {
            return item.Value;
        }
    }

    public void Remove(int key)
    {
        var item = GetItem(key);

        if (item != null) // exists
        {
            _myHashMapItems.Remove(item);
        }
    }

    private MyHashMapItem? GetItem(int key)
    {
        return _myHashMapItems.FirstOrDefault(x => x.Key == key);
    }

    private class MyHashMapItem
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */