using System.Reflection;

namespace Famoser.YoutubeDataApiWrapper.Portable.Util
{
    public static class ObjectExtensions
    {
        public static TProperty GetPropertyValue<TProperty>(this object obj, string propertyName)
        {
            var prop = obj.GetType().GetRuntimeProperty(propertyName);
            if (prop == null)
            {
                return default(TProperty);
            }
            return (TProperty) prop.GetValue(obj, null);
        }

        public static object GetPropertyValue(this object obj, string propertyName)
        {
            var prop = obj.GetType().GetRuntimeProperty(propertyName);
            return prop?.GetValue(obj, null);
        }
    }
}
