
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectLanguageRequestFormat
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
    public static class DetectLanguageRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectLanguageRequestFormat value)
        {
            return value switch
            {
                DetectLanguageRequestFormat.Html => "html",
                DetectLanguageRequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectLanguageRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => DetectLanguageRequestFormat.Html,
                "text" => DetectLanguageRequestFormat.Text,
                _ => null,
            };
        }
    }
}