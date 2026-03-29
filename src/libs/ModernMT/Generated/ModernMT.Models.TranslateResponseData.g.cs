
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public string? Translation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCharacters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public int? Characters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedLanguage")]
        public string? DetectedLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("altTranslations")]
        public global::System.Collections.Generic.IList<string>? AltTranslations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextVector")]
        public string? ContextVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateResponseData" /> class.
        /// </summary>
        /// <param name="translation"></param>
        /// <param name="billedCharacters"></param>
        /// <param name="characters"></param>
        /// <param name="detectedLanguage"></param>
        /// <param name="altTranslations"></param>
        /// <param name="contextVector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateResponseData(
            string? translation,
            int? billedCharacters,
            int? characters,
            string? detectedLanguage,
            global::System.Collections.Generic.IList<string>? altTranslations,
            string? contextVector)
        {
            this.Translation = translation;
            this.BilledCharacters = billedCharacters;
            this.Characters = characters;
            this.DetectedLanguage = detectedLanguage;
            this.AltTranslations = altTranslations;
            this.ContextVector = contextVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateResponseData" /> class.
        /// </summary>
        public TranslateResponseData()
        {
        }
    }
}