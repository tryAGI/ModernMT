#nullable enable

namespace ModernMT.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchTranslateRequestPriorityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModernMT.BatchTranslateRequestPriority>
    {
        /// <inheritdoc />
        public override global::ModernMT.BatchTranslateRequestPriority Read(
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
                        return global::ModernMT.BatchTranslateRequestPriorityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModernMT.BatchTranslateRequestPriority)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModernMT.BatchTranslateRequestPriority);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModernMT.BatchTranslateRequestPriority value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModernMT.BatchTranslateRequestPriorityExtensions.ToValueString(value));
        }
    }
}
