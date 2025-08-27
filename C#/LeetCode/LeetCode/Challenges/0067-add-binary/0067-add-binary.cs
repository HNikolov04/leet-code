namespace LeetCode.Challenges._0067_add_binary;

public class _0067_add_binary
{
    public string AddBinary(string a, string b)
    {
        int firstStringIndex = a.Length - 1;
        int secondStringIndex = b.Length - 1;

        int carry = 0;
        int sum = 0;

        string result = string.Empty;

        while (firstStringIndex >= 0 || secondStringIndex >= 0)
        {
            sum = carry;

            if (firstStringIndex >= 0)
            {
                sum += a[firstStringIndex--] - '0';
            }
            if (secondStringIndex >= 0)
            {
                sum += b[secondStringIndex--] - '0';
            }

            if (sum > 1)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            result += (sum % 2).ToString();
        }

        if (carry > 0)
        {
            result += carry.ToString();
        }

        return Reverse(result);
    }

    private string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();

        Array.Reverse(charArray);

        return new string(charArray);
    }
}
