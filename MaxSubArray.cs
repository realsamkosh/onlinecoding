public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int size = nums.Length;
        int max_r = int.MinValue;
        int max_ending = 0;

        for (int i = 0; i < size; i++)
        {
            max_ending = max_ending + nums[i];
            if (max_r < max_ending)
            {
                max_r = max_ending;
            }

            if (max_ending < 0)
            {
                max_ending = 0;
            }
        }
        return max_r;
    }
}