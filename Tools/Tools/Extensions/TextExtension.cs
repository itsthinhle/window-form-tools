namespace Tools.Extensions;

internal static class TextExtension
{
    public static int ToInt32(this string number)
    {
        return string.IsNullOrEmpty(number) ? 0 : int.Parse(number);
    }
}
