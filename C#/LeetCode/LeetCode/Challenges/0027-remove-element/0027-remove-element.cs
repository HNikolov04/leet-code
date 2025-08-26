namespace LeetCode.Challenges._0027_remove_element;

public class _0027_remove_element
{
    public int RemoveElement(int[] nums, int val) // [3,2,2,3], val = 3
    {
        int counter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }

            (nums[counter], nums[i]) = (nums[i], nums[counter]);

            counter++;
        }

        return counter;
    }
}

