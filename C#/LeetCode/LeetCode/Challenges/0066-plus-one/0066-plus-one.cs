namespace LeetCode.Challenges._0066_plus_one;

public class _0066_plus_one
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;

                return digits;
            }

            digits[i] = 0;
        }

        int[] newDigits = new int[digits.Length + 1];

        newDigits[0] = 1;

        return newDigits;
    }
}
