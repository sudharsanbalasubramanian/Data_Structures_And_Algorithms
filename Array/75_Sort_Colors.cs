namespace Data_Structures_And_Algorithms.Array;

internal class _75_Sort_Colors
{
    //dutch national flag algorithm
    //https://leetcode.com/problems/sort-colors/description/
    public void SortColors(int[] nums)
    {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while(mid <= high)
        {
            if (nums[mid] == 0)
            {
                (nums[low], nums[mid]) = (nums[mid], nums[low]);
                low++;
                mid++;
            }
            else if(nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                (nums[mid], nums[high]) = (nums[high], nums[mid]);
                high--;
            }
        }
    }
}
