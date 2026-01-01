namespace Data_Structures_And_Algorithms.Array;

public sealed class _14_Longest_Common_Prefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        ArgumentNullException.ThrowIfNull(strs);

        if (strs.Length == 0)
        {
            return string.Empty;
        }

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix[..^1]; 

                if (prefix.Length == 0)
                {
                    return string.Empty;
                }
            }
        }

        return prefix;
    }

}
