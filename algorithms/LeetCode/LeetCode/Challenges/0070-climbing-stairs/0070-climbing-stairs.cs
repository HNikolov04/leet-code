namespace LeetCode.Challenges._0070_climbing_stairs;

public class _0070_climbing_stairs
{
    public int ClimbStairs(int n)
    {
        int[] data = new int[n+1];
        data[0] = 1;
        data[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            data[i] = data[i-1] + data[i-2];
        }

        return data[n];
    }
}
