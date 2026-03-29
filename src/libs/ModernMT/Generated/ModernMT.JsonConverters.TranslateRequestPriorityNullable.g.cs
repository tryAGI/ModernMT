#nullable enable

namespace ModernMT.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranslateRequestPriorityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModernMT.TranslateRequestPriority?>
    {
        /// <inheritdoc />
        public override global::ModernMT.TranslateRequestPriority? Read(
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
                        return global::ModernMT.TranslateRequestPriorityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModernMT.TranslateRequestPriority)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModernMT.TranslateRequestPriority?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModernMT.TranslateRequestPriority? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModernMT.TranslateRequestPriorityExtensions.ToValueString(value.Value));
            }
        }
    }
}
