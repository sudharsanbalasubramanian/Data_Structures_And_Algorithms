namespace Data_Structures_And_Algorithms.Array;

public sealed class _242_Valid_Anagram
{
    //https://leetcode.com/problems/valid-anagram/
    public bool IsAnagram(string s1, string s2)
    {
        ArgumentException.ThrowIfNullOrEmpty(s1, nameof(s1));
        ArgumentException.ThrowIfNullOrEmpty(s2, nameof(s2));

        if (s1.Length != s2.Length)
        {
            return false;
        }

        int[] counts = new int[256];

        for (int i = 0; i < s1.Length; i++)
        {
            counts[s1[i]]++;
        }

        for (int i = 0; i < s2.Length; i++)
        {
            counts[s2[i]]--;

            if (counts[s2[i]] < 0)
            {
                return false;
            }
        }

        return true;
    }


}