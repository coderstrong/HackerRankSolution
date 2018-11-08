// Complete the arrayManipulation function below.
static long arrayManipulation(int n, int[][] queries) {
    long[] mans = new long[n + 1];
    for (int i = 0; i < queries.GetLength(0); i++)
    {
        int a = queries[i][0];
        int b = queries[i][1];
        long k = (long)queries[i][2];
        mans[a] += k;
        if (b + 1 <= n) mans[b + 1] -= k;
    }

    long max = 0;
    long sum = 0;
    for (int i = 0; i < mans.Length; i++)
    {
        sum += mans[i];
        max = Math.Max(max, sum);
    }

    return max;

}