namespace Data_Structures_And_Algorithms.Array;
//https://leetcode.com/problems/two-sum/
public sealed class _1_Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dict.TryGetValue(complement, out int index))
            {
                return [index, i];
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }

        return [-1, -1];
    }

}