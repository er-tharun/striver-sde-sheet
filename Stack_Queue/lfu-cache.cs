//https://leetcode.com/problems/lfu-cache
public class LFUCache
{
    IDictionary<int, DoubleLinkedList> frequencyMap;
    IDictionary<int, DLLNode> nodeMap;
    DLLNode nodeMapHead;
    DLLNode nodeMapTail;
    int capacity;
    int minFrequency = 0;
    public LFUCache(int capacity)
    {
        frequencyMap = new Dictionary<int, DoubleLinkedList>();
        nodeMap = new Dictionary<int, DLLNode>();
        nodeMapHead = new DLLNode(-1, -1);
        nodeMapTail = new DLLNode(-1, -1);
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (!nodeMap.ContainsKey(key)) return -1;
        DLLNode node = nodeMap[key];
        UpdateNode(node);
        return node.Value;
    }

    public void Put(int key, int value)
    {
        if (capacity == 0) return;
        if (nodeMap.ContainsKey(key))
        {
            nodeMap[key].Value = value;
            UpdateNode(nodeMap[key]);
        }
        else
        {
            if (nodeMap.Count == capacity)
            {
                if (frequencyMap.ContainsKey(minFrequency))
                {
                    DoubleLinkedList list = frequencyMap[minFrequency];
                    nodeMap.Remove(list.tail.prev.Key);
                    list.RemoveNode(list.tail.prev);
                }
            }
            minFrequency = 1;
            var node = new DLLNode(key, value);
            if (!frequencyMap.ContainsKey(minFrequency))
            {
                DoubleLinkedList list = new DoubleLinkedList();
                frequencyMap.Add(minFrequency, list);
                list.AddNode(node);
                nodeMap.Add(key, node);
            }
            else
            {
                var list = frequencyMap[minFrequency];
                list.AddNode(node);
                nodeMap.Add(key, node);
            }
        }
    }

    public void UpdateNode(DLLNode node)
    {
        int oldFreq = node.Frequency;
        DoubleLinkedList list = frequencyMap[node.Frequency];
        list.RemoveNode(node);
        if (frequencyMap[oldFreq].head.next == frequencyMap[oldFreq].tail)
        {
            Console.WriteLine(minFrequency);
            frequencyMap.Remove(node.Frequency);
            if (minFrequency == oldFreq)
                minFrequency++;
        }
        node.Frequency++;
        if (frequencyMap.ContainsKey(node.Frequency))
        {
            var dll = frequencyMap[node.Frequency];
            dll.AddNode(node);
        }
        else
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            dll.AddNode(node);
            frequencyMap.Add(node.Frequency, dll);
        }
    }
}

public class DLLNode
{
    public DLLNode next { get; set; }
    public DLLNode prev { get; set; }
    public int Key { get; set; }
    public int Value { get; set; }
    public int Frequency { get; set; }

    public DLLNode(int key, int value)
    {
        this.Key = key;
        this.Value = value;
        this.Frequency = 1;
    }
}

public class DoubleLinkedList
{
    public DLLNode head { get; set; }
    public DLLNode tail { get; set; }
    public int count { get; set; }

    public DoubleLinkedList()
    {
        head = new DLLNode(-1, -1);
        tail = new DLLNode(-1, -1);
        head.next = tail;
        tail.prev = head;
        count = 0;
    }

    public void AddNode(DLLNode node)
    {
        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
        count++;
    }

    public void RemoveNode(DLLNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
        count--;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */