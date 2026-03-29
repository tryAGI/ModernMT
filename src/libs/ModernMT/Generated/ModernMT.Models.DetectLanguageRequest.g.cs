
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectLanguageRequest
    {
        /// <summary>
        /// Text to detect language of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModernMT.JsonConverters.DetectLanguageRequestFormatJsonConverter))]
        public global::ModernMT.DetectLanguageRequestFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageRequest" /> class.
        /// </summary>
        /// <param name="q">
        /// Text to detect language of
        /// </param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectLanguageRequest(
            string q,
            global::ModernMT.DetectLanguageRequestFormat? format)
        {
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageRequest" /> class.
        /// </summary>
        public DetectLanguageRequest()
        {
        }
    }
}