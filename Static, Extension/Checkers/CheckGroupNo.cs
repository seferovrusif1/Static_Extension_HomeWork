namespace Static__Extension.Checkers;
internal static class CheckGroupNo
{
   public  static bool CheckGroupNoo( this string value)
   {
        if (value.Length == 4)
        {
            for (int i = 1; i < 4; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    return false;
                }
            }
            if ((int)value[0] < 65 || (int)value[0] > 90)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
        return true;
   }
}
