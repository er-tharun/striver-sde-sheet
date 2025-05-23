//https://leetcode.com/problems/min-stack/

public class MinStack
{
    Stack<long> stack;
    long min;
    public MinStack()
    {
        stack = new Stack<long>();
        min = long.MaxValue;
    }

    public void Push(int val)
    {
        if (stack.Count == 0)
        {
            stack.Push(val);
            min = val;
        }
        else
        {
            if (val < min)
            {
                stack.Push((2 * val) - min);
                min = val;
                Console.WriteLine(min);
            }
            else
                stack.Push(val);
        }
    }

    public void Pop()
    {
        if (stack.Count == 0) return;
        long x = stack.Pop();
        if (x <= min)
            min = (2 * min) - x;
    }

    public int Top()
    {
        if (stack.Peek() < min)
            return (int)min;
        return (int)stack.Peek();
    }

    public int GetMin()
    {
        return (int)min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */