
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchTranslateRequestPriority
    {
        /// <summary>
        /// 
        /// </summary>
        Background,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchTranslateRequestPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchTranslateRequestPriority value)
        {
            return value switch
            {
                BatchTranslateRequestPriority.Background => "background",
                BatchTranslateRequestPriority.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchTranslateRequestPriority? ToEnum(string value)
        {
            return value switch
            {
                "background" => BatchTranslateRequestPriority.Background,
                "normal" => BatchTranslateRequestPriority.Normal,
                _ => null,
            };
        }
    }
}