
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchTranslateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Q { get; set; }

        /// <summary>
        /// Webhook URL for batch completion callback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Webhook { get; set; }

        /// <summary>
        /// Optional metadata passed through to webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hints")]
        public string? Hints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModernMT.JsonConverters.BatchTranslateRequestPriorityJsonConverter))]
        public global::ModernMT.BatchTranslateRequestPriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranslateRequest" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="q"></param>
        /// <param name="webhook">
        /// Webhook URL for batch completion callback
        /// </param>
        /// <param name="metadata">
        /// Optional metadata passed through to webhook
        /// </param>
        /// <param name="hints"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchTranslateRequest(
            string source,
            string target,
            global::System.Collections.Generic.IList<string> q,
            string webhook,
            object? metadata,
            string? hints,
            global::ModernMT.BatchTranslateRequestPriority? priority)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.Metadata = metadata;
            this.Hints = hints;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranslateRequest" /> class.
        /// </summary>
        public BatchTranslateRequest()
        {
        }
    }
}