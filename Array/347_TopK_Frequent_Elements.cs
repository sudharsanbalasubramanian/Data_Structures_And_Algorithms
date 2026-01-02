namespace Data_Structures_And_Algorithms.Array;

public sealed class _347_TopK_Frequent_Elements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;
        }

        var buckets = new List<int>[nums.Length + 1];

        foreach (var pair in freq)
        {
            int count = pair.Value;

            if (buckets[count] is null)
            {
                buckets[count] = [];
            }

            buckets[count].Add(pair.Key);
        }

        var result = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return [.. result.Take(k)];
    }
}
