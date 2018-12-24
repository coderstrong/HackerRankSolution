static void checkMagazine(string[] magazine, string[] note)
{
    Dictionary<string, int> countingnote = note.GroupBy(x => x)
        .ToDictionary(g => g.Key, g=> g.Count());
    Dictionary<string, int> countingmagezine = magazine.GroupBy(x => x)
        .ToDictionary(g => g.Key, g => g.Count());

    if (countingnote.Count > countingmagezine.Count)
    {
        Console.Write("No");
        return;
    }

    foreach (var key in countingnote)
    {
        if (!countingmagezine.ContainsKey(key.Key) || countingmagezine[key.Key] < key.Value)
        {
            Console.Write("No");
            return;
        }
    }

    Console.Write("Yes");
}