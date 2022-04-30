using System.Text.RegularExpressions;

namespace Betelguese.Extentions
{
    public static class StringExtentions
    {
        public static string TrimAndReduce(this string str)
        {
            return ConvertWhitespacesToSingleSpaces(str).Trim();
        }

        public static string ConvertWhitespacesToSingleSpaces(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }
    }
}
