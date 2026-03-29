
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// Translation priority
    /// </summary>
    public enum TranslateRequestPriority
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
    public static class TranslateRequestPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestPriority value)
        {
            return value switch
            {
                TranslateRequestPriority.Background => "background",
                TranslateRequestPriority.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestPriority? ToEnum(string value)
        {
            return value switch
            {
                "background" => TranslateRequestPriority.Background,
                "normal" => TranslateRequestPriority.Normal,
                _ => null,
            };
        }
    }
}