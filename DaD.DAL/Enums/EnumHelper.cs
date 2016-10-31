using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace DaD.DAL.Enums
{
    public static class EnumHelper
    {
        public static string GetDisplayValue<T>(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var displayAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (displayAttributes == null) return string.Empty;
            string result;

            if (displayAttributes.Length > 0)
            {
                var displayAttribute = displayAttributes[0];
                if (displayAttribute.ResourceType != null)
                {
                    var resourceManager = new ResourceManager(displayAttribute.ResourceType);
                    result = resourceManager.GetString(displayAttribute.Name);
                }
                else
                {
                    result = displayAttribute.Name;
                }
            }
            else
            {
                result = value.ToString();
            }
            return result;
        }
    }
}
