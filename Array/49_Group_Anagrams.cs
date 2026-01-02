namespace Data_Structures_And_Algorithms.Array;

public sealed class _49_Group_Anagrams
{
    //https://leetcode.com/problems/group-anagrams/
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            int[] counts = new int[26];

            foreach (char c in str)
            {
                counts[c - 'a']++;
            }

            string key = string.Join('#', counts);

            if (!dict.TryGetValue(key, out var list))
            {
                dict[key] = list = [];
            }

            list.Add(str);
        }

        return [.. dict.Values];
    }

}