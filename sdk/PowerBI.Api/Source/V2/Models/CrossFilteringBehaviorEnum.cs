// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CrossFilteringBehaviorEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CrossFilteringBehaviorEnum
    {
        [EnumMember(Value = "OneDirection")]
        OneDirection,
        [EnumMember(Value = "BothDirections")]
        BothDirections,
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    internal static class CrossFilteringBehaviorEnumEnumExtension
    {
        internal static string ToSerializedValue(this CrossFilteringBehaviorEnum? value)
        {
            return value == null ? null : ((CrossFilteringBehaviorEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CrossFilteringBehaviorEnum value)
        {
            switch( value )
            {
                case CrossFilteringBehaviorEnum.OneDirection:
                    return "OneDirection";
                case CrossFilteringBehaviorEnum.BothDirections:
                    return "BothDirections";
                case CrossFilteringBehaviorEnum.Automatic:
                    return "Automatic";
            }
            return null;
        }

        internal static CrossFilteringBehaviorEnum? ParseCrossFilteringBehaviorEnum(this string value)
        {
            switch( value )
            {
                case "OneDirection":
                    return CrossFilteringBehaviorEnum.OneDirection;
                case "BothDirections":
                    return CrossFilteringBehaviorEnum.BothDirections;
                case "Automatic":
                    return CrossFilteringBehaviorEnum.Automatic;
            }
            return null;
        }
    }
}
