
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// Optional metadata passed through to webhook
    /// </summary>
    public sealed partial class BatchTranslateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}