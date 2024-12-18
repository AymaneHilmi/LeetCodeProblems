namespace LeetCodeProblems.Easy;

static public class TwoSumClass
{
    static public int[] TwoSum(int[] nums, int target)
    {
        int len = nums.Length;
        Dictionary<int, int> dict = new Dictionary<int, int>(len);
        for (int i = 0; i < len; i++)
        {
            if (dict.TryGetValue(target - nums[i], out var value))
                return [value, i];

            dict[nums[i]] = i;
        }
        return [];
    }
}