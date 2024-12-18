namespace LeetCodeProblems.Easy;

static public class TopKFrequentClass
{
    static public int[] TopKFrequent(int[] nums, int k)
    {
        Array.Sort(nums);
        Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);
        foreach (var item in nums)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }
        var arrres = dict.ToList().OrderByDescending(e => e.Value);
        return arrres.Select(e => e.Key).Take(k).ToArray();
    }
}