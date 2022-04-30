using System.Text.RegularExpressions;

namespace Betelguese.Extentions
{
    public static class StringExtentions
    {
        public static string ToSingleSpaces(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }
    }
}
