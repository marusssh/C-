public static class Myliberary
{
public static int Pow (int a, int b)
{
    int result = 1;
    for (int i = 0; i<b; i++)
    {
        result = result * a;
    }
    return result;
}

public static int ConvertTo15 (int[] value)

{
    int result =0;
    int count =value.Length;
    for (int i = 0; i < count; i++)
    {
        result += value[i] * Pow(15, count -1 -i);
    }
    return result;
}
}