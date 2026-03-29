
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddGlossaryRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Equivalent,
        /// <summary>
        /// 
        /// </summary>
        Unidirectional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddGlossaryRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddGlossaryRequestType value)
        {
            return value switch
            {
                AddGlossaryRequestType.Equivalent => "equivalent",
                AddGlossaryRequestType.Unidirectional => "unidirectional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddGlossaryRequestType? ToEnum(string value)
        {
            return value switch
            {
                "equivalent" => AddGlossaryRequestType.Equivalent,
                "unidirectional" => AddGlossaryRequestType.Unidirectional,
                _ => null,
            };
        }
    }
}