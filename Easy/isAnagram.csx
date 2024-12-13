var res = IsAnagram("racecar", "carrace");
var res1 = IsAnagram("jar", "jam");

return;

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
