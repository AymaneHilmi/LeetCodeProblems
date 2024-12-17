namespace LeetCodeProblems.Easy;

static public class IsAnagramClass
{
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        s = new string(s.OrderBy(s => s).ToArray());
        t = new string(t.OrderBy(t => t).ToArray());

        return s == t;
    }
}