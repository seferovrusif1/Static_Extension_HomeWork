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
    public static string Capitalizee(this string fulname)
    {
        fulname = fulname.ToLower();
        string[] words = fulname.Split(' ');
        fulname = char.ToUpper((words[0])[0])+words[0].Substring(1)+" "+char.ToUpper((words[1])[0]) + words[1].Substring(1);
        return fulname;
    }
}
