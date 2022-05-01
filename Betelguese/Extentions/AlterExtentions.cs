using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Betelguese.Extentions
{
    public static class AlterExtentions
    {
        public static string ToJson<T>(this T instance)
            => JsonConvert.SerializeObject(instance);
        public static T To<T>(this string instance)
        {
            return JsonConvert.DeserializeObject<T>(instance);
        }
    }
}
