namespace LeetCode.Challenges._0009_palindrome_number;

public class _0009_palindrome_number
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int original = x;

        int reversed = 0;

        while (x != 0)
        {
            int remainder = x % 10;

            reversed = reversed * 10 + remainder;

            x /= 10;
        }

        return original == reversed;
    }
}
