
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextVectorRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hints")]
        public string? Hints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextVectorRequest" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="targets"></param>
        /// <param name="text"></param>
        /// <param name="hints"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextVectorRequest(
            string source,
            global::System.Collections.Generic.IList<string> targets,
            string text,
            string? hints,
            int? limit)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Hints = hints;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextVectorRequest" /> class.
        /// </summary>
        public ContextVectorRequest()
        {
        }
    }
}