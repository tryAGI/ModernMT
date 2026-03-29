
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectLanguageResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedLanguage")]
        public string? DetectedLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCharacters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageResponseData" /> class.
        /// </summary>
        /// <param name="detectedLanguage"></param>
        /// <param name="billedCharacters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectLanguageResponseData(
            string? detectedLanguage,
            int? billedCharacters)
        {
            this.DetectedLanguage = detectedLanguage;
            this.BilledCharacters = billedCharacters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectLanguageResponseData" /> class.
        /// </summary>
        public DetectLanguageResponseData()
        {
        }
    }
}