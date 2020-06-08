using Newtonsoft.Json.Serialization;

namespace CloudCommerceTechTest.HelperClasses
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}
