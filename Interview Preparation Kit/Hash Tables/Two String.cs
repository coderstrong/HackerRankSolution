// Complete the twoStrings function below.
static string twoStrings(string s1, string s2) {
    Dictionary<char, char> dics1 = s1.GroupBy(u=>u).ToDictionary(x => x.Key, x=>x.Key);
    Dictionary<char, char> dics2 = s2.GroupBy(u => u).ToDictionary(u => u.Key, u=> u.Key);

    foreach (var item in dics1)
    {
        if (dics2.ContainsKey(item.Key))
        {
            return "YES";
        }
    }
    return "NO";
}