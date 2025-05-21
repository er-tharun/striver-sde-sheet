//https://leetcode.com/problems/lru-cache

public class LRUCache
{
    DLLNode head = new DLLNode(-1, -1, null, null);
    DLLNode tail = new DLLNode(-1, -1, null, null);
    int capacity;
    IDictionary<int, DLLNode> map;
    public LRUCache(int capacity)
    {
        head.next = tail;
        tail.prev = head;
        this.capacity = capacity;
        this.map = new Dictionary<int, DLLNode>();
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key)) return -1;
        DLLNode node = map[key];
        Remove(node);
        Insert(node);
        return node.val;
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
            Remove(map[key]);
        else
        {
            if (map.Count == capacity)
                Remove(tail.prev);
        }
        Insert(new DLLNode(key, value, null, null));
    }

    public void Insert(DLLNode node)
    {
        if (map.ContainsKey(node.key))
            map.Remove(node.key);
        map.Add(node.key, node);
        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
    }

    public void Remove(DLLNode node)
    {
        map.Remove(node.key);
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
}

public class DLLNode
{
    public DLLNode prev { get; set; }
    public DLLNode next { get; set; }
    public int key { get; set; }
    public int val { get; set; }

    public DLLNode(int key, int val)
    {
        this.key = key;
        this.val = val;
    }

    public DLLNode(int key, int val, DLLNode prev, DLLNode next)
    {
        this.key = key;
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */