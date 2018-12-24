// Complete the sockMerchant function below.
static int sockMerchant(int n, int[] ar)
{
    int result = 0;
    Dictionary<int, List<int>> temp = new Dictionary<int, List<int>>();
    for (int i = 0; i < n; i++)
    {
        var exits = temp.Where(u => u.Key == ar[i]).FirstOrDefault();
        if (exits.Key == ar[i])
        {
            exits.Value.Add(ar[i]);
        }
        else
        {
            temp.Add(ar[i], new List<int> { ar[i] });
        }
    }

    foreach (var item in temp)
    {
        result += (item.Value.Count / 2);
    }

    return result;
}