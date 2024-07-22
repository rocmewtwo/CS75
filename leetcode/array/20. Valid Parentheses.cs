// var s = new _20_Valid_Parentheses();
// Console.WriteLine(s.IsValid("()")); // true
// Console.WriteLine(s.IsValid("()[]{}")); // true
// Console.WriteLine(s.IsValid("(]")); // false

public class _20_Valid_Parentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var mapping = new Dictionary<char, char> {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (char c in s)
        {
            // If the current character is a closing bracket
            if (mapping.ContainsKey(c))
            {
                if (stack.Count > 0 && stack.Peek() == mapping[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}