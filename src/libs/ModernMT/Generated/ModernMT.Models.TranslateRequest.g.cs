
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateRequest
    {
        /// <summary>
        /// Source language code (e.g., "en")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Target language code (e.g., "it")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Text to translate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// Comma-separated memory IDs for adaptive translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hints")]
        public string? Hints { get; set; }

        /// <summary>
        /// Translation priority
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModernMT.JsonConverters.TranslateRequestPriorityJsonConverter))]
        public global::ModernMT.TranslateRequestPriority? Priority { get; set; }

        /// <summary>
        /// Whether to treat the text as multiline
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiline")]
        public bool? Multiline { get; set; }

        /// <summary>
        /// Text format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModernMT.JsonConverters.TranslateRequestFormatJsonConverter))]
        public global::ModernMT.TranslateRequestFormat? Format { get; set; }

        /// <summary>
        /// Number of alternative translations to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt_translations")]
        public int? AltTranslations { get; set; }

        /// <summary>
        /// Whether to mask profanities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_profanities")]
        public bool? MaskProfanities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// Source language code (e.g., "en")
        /// </param>
        /// <param name="target">
        /// Target language code (e.g., "it")
        /// </param>
        /// <param name="q">
        /// Text to translate
        /// </param>
        /// <param name="hints">
        /// Comma-separated memory IDs for adaptive translation
        /// </param>
        /// <param name="priority">
        /// Translation priority
        /// </param>
        /// <param name="multiline">
        /// Whether to treat the text as multiline
        /// </param>
        /// <param name="format">
        /// Text format
        /// </param>
        /// <param name="altTranslations">
        /// Number of alternative translations to return
        /// </param>
        /// <param name="maskProfanities">
        /// Whether to mask profanities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateRequest(
            string source,
            string target,
            string q,
            string? hints,
            global::ModernMT.TranslateRequestPriority? priority,
            bool? multiline,
            global::ModernMT.TranslateRequestFormat? format,
            int? altTranslations,
            bool? maskProfanities)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Hints = hints;
            this.Priority = priority;
            this.Multiline = multiline;
            this.Format = format;
            this.AltTranslations = altTranslations;
            this.MaskProfanities = maskProfanities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest" /> class.
        /// </summary>
        public TranslateRequest()
        {
        }
    }
}