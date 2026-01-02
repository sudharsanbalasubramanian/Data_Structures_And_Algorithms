using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_And_Algorithms.Array;

public sealed class _27_Remove_Element
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0; // index to place the next valid element

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k; // number of elements not equal to val
    }

}
