using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Betelguese.Extentions
{
    public static class AlterExtentions
    {
        public static string ToJson<T>(this T instance)
    => JsonConvert.SerializeObject(instance, JsonSettings.SerializerDefaults);
    }
}
