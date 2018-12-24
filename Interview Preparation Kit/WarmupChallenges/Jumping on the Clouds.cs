// Complete the jumpingOnClouds function below.
static int jumpingOnClouds(int[] c)
{
    int result = 0;
    int index = 0;
    int nextcheck = 0;
    while (index < c.Length - 1)
    {
        nextcheck = index + 2;
        if (nextcheck > c.Length-1 || c[nextcheck] == 1)
        {
            nextcheck = index + 1;
        }
        if (c[nextcheck] == 0)
        {
            index = nextcheck;
            result++;
        }
        else
        {
            index = nextcheck;
            result++;
        }
    }
    return result;
}