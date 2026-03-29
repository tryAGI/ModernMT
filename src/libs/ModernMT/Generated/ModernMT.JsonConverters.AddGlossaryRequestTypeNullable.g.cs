#nullable enable

namespace ModernMT.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddGlossaryRequestTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModernMT.AddGlossaryRequestType?>
    {
        /// <inheritdoc />
        public override global::ModernMT.AddGlossaryRequestType? Read(
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
                        return global::ModernMT.AddGlossaryRequestTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModernMT.AddGlossaryRequestType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModernMT.AddGlossaryRequestType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModernMT.AddGlossaryRequestType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModernMT.AddGlossaryRequestTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
