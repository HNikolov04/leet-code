namespace LeetCode.Challenges._0035_search_insert_position;

public class _0035_search_insert_position
{
    public int SearchInsert(int[] nums, int target)
    {
        int lower = 0;
        int upper = nums.Length - 1;

        if (nums[lower] >= target)
        {
            return lower;
        }
        if (nums[upper] < target)
        {
            return nums.Length;
        }
        if (nums[upper] == target)
        {
            return upper;
        }

        while (lower < upper)
        {
            if (lower == upper - 1)
            {
                return upper;
            }

            int current = upper - ((upper - lower) / 2);

            if (nums[current] == target)
            {
                return current;
            }
            if (nums[current] < target)
            {
                lower = current;
            }
            if (nums[current] > target)
            {
                upper = current;
            }
        }
        return upper;
    }
}
