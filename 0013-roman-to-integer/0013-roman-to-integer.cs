public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romans = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int length = s.Length;

        int result = romans[s[length - 1]];

        for (int i = length - 1; i > 0; i--)
        {
            if (romans[s[i - 1]] >= romans[s[i]])
            {
                result += romans[s[i - 1]];
            }
            else
            {
                result -= romans[s[i - 1]];
            }
        }

        return result;
    }
}