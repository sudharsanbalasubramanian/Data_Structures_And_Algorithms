namespace Data_Structures_And_Algorithms.Array;

public sealed class _169_Majority_Element
{
    public static int MajorityElement(int[] elements)
    {
        // Step 1: Find candidate
        int candidate = elements[0];
        int count = 1;

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }

            if (count == 0)
            {
                candidate = elements[i];
                count = 1;
            }
        }

        count = 0;
        foreach (var num in elements)
        {
            if (num == candidate)
            {
                count++;
            }
        }

        return count > elements.Length / 2 ? candidate : 0; 
    }
}
