//https://leetcode.com/problems/valid-parentheses/

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                stack.Push(s[i]);
            else
            {
                if (s[i] == ')')
                {
                    if (stack.Count != 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                }
                else if (s[i] == '}')
                {
                    if (stack.Count != 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                }
                else
                {
                    if (stack.Count != 0 && stack.Peek() == '[') stack.Pop();
                    else return false;
                }
            }
        }

        if (stack.Count == 0) return true;
        else return false;
    }
}