static int sherlockAndAnagrams(string s)
{
    int result = 0;

    List<string> temp = new List<string>();

    for (int i = 1; i < s.Length; i++)
    {
        temp.Add(s.Substring(0, i));
    }

    int start = 1;
    while (start <= s.Length)
    {
        for (int i = 1; i <= s.Length - start; i++)
        {
            temp.Add(s.Substring(start, i));
        }
        start++;
    }

    var dic = temp.GroupBy(y => string.Concat(y.OrderBy(j => j))).ToDictionary(y => y.Key, y => y.Count());

    foreach (var item in dic)
    {
        if (item.Value == 1)
        {
            continue;
        }

        for (int i = 1; i <= item.Value - 1; i++)
        {
            result += (item.Value - i);
        }
        
    }

    return result;
}