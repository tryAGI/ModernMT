#nullable enable

namespace ModernMT.JsonConverters
{
    /// <inheritdoc />
    public sealed class DetectLanguageRequestFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModernMT.DetectLanguageRequestFormat>
    {
        /// <inheritdoc />
        public override global::ModernMT.DetectLanguageRequestFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ModernMT.DetectLanguageRequestFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModernMT.DetectLanguageRequestFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModernMT.DetectLanguageRequestFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModernMT.DetectLanguageRequestFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModernMT.DetectLanguageRequestFormatExtensions.ToValueString(value));
        }
    }
}
