
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEstimationRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sentence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sentence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Translation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEstimationRequest" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="sentence"></param>
        /// <param name="translation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEstimationRequest(
            string source,
            string target,
            string sentence,
            string translation)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Sentence = sentence ?? throw new global::System.ArgumentNullException(nameof(sentence));
            this.Translation = translation ?? throw new global::System.ArgumentNullException(nameof(translation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEstimationRequest" /> class.
        /// </summary>
        public QualityEstimationRequest()
        {
        }
    }
}