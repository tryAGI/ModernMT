
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchTranslateResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enqueued")]
        public bool? Enqueued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranslateResponseData" /> class.
        /// </summary>
        /// <param name="enqueued"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchTranslateResponseData(
            bool? enqueued)
        {
            this.Enqueued = enqueued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTranslateResponseData" /> class.
        /// </summary>
        public BatchTranslateResponseData()
        {
        }
    }
}