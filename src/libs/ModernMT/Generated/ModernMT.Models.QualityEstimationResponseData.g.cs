
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEstimationResponseData
    {
        /// <summary>
        /// Quality score from 0.0 to 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEstimationResponseData" /> class.
        /// </summary>
        /// <param name="score">
        /// Quality score from 0.0 to 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEstimationResponseData(
            float? score)
        {
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEstimationResponseData" /> class.
        /// </summary>
        public QualityEstimationResponseData()
        {
        }
    }
}