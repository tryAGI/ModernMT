
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextVectorResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        public global::System.Collections.Generic.Dictionary<string, string>? Vectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextVectorResponseData" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="vectors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextVectorResponseData(
            string? source,
            global::System.Collections.Generic.Dictionary<string, string>? vectors)
        {
            this.Source = source;
            this.Vectors = vectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextVectorResponseData" /> class.
        /// </summary>
        public ContextVectorResponseData()
        {
        }
    }
}