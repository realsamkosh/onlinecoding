public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var prep = nums.GroupBy(x => x);
        if (prep.Any(x => x.Count() > 1))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}