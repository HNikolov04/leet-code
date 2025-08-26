namespace LeetCode.Challenges._0001_two_sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (hashTable.ContainsKey(complement))
            {
                return new int[] { hashTable[complement], i };
            }

            hashTable[nums[i]] = i;
        }

        throw new Exception("Not Found");
    }
}
