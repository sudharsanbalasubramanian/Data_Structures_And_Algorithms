namespace Data_Structures_And_Algorithms.Array;

public sealed class _217_Contains_Duplicate
{
    //https://leetcode.com/problems/contains-duplicate/
    public bool ContainsDuplicate(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        HashSet<int> visited = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!visited.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
