namespace Static__Extension.Checkers;
internal static class CheckFullname
{
    public static bool  CheckFullnamee(this string fulname)
    {
        string[]  words = fulname.Split(' ');
        if(words.Length == 2 && words[0].Length>=3 && words[1].Length>=3 )
        {
           return true;
        }
        return false;
    }
}
