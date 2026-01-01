namespace Data_Structures_And_Algorithms.Array;

public sealed class _1929_Concatenation_of_Array
{
    //https://leetcode.com/problems/concatenation-of-array/
    public int[] GetConcatenation(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        
        var result = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }

        return result;
    }
}
