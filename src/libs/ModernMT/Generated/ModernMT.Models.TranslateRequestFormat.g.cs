
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// Text format
    /// </summary>
    public enum TranslateRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestFormat value)
        {
            return value switch
            {
                TranslateRequestFormat.Html => "html",
                TranslateRequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => TranslateRequestFormat.Html,
                "text" => TranslateRequestFormat.Text,
                _ => null,
            };
        }
    }
}