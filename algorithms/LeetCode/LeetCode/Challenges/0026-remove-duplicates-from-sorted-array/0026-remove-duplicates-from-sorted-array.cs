namespace LeetCode.Challenges._0026_remove_duplicates_from_sorted_array;

public class _0026_remove_duplicates_from_sorted_array
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int pointer = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[pointer++] = nums[i];
            }
        }

        return pointer;
    }
}
