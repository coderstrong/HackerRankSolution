static int countingValleys(int n, string s)
{
    int result = 0;
    int previous_state = 0;
    int state = s[0] == 'D' ? -1 : 1;
    for (int i = 1; i < n; i++)
    {
        previous_state = state;
        state = s[i] == 'D' ? state - 1 : state + 1;

        if (state == 0 && previous_state < 0)
        {
            result++;
        }
    }

    return result;
}