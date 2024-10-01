public class Solution
{
    public bool IsValid(string s) // Input: s = "([])"
    {
        Dictionary<char, char> matches = new()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        Stack<char> parentheses = new();

        foreach (var parenthesis in s)
        {
            if (matches.ContainsKey(parenthesis))
            {
                parentheses.Push(parenthesis);
                continue;
            }

            if (parentheses.Count == 0)
            {
                return false;
            }

            char openingParenthesis = parentheses.Pop();

            if (matches[openingParenthesis] != parenthesis)
            {
                return false;
            }
        }

        return parentheses.Count == 0;
    }
}