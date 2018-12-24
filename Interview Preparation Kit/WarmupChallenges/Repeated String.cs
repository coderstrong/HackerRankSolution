static long repeatedString(string s, long n)
{
    if (s.Length > n)
    {
        s = s.Substring(0, (int)n);
    }

    string sur = s.Substring(0, (int) (n % s.Length));
    char charFind = 'a';
    return s.Count(xx=>xx == charFind) * (n / s.Length) + sur.Count(u=> u == charFind);
}