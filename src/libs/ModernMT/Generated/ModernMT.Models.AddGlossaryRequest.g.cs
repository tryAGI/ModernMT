
#nullable enable

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddGlossaryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModernMT.JsonConverters.AddGlossaryRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModernMT.AddGlossaryRequestType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tuid")]
        public string? Tuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModernMT.AddGlossaryRequestTerm> Terms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGlossaryRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="terms"></param>
        /// <param name="tuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddGlossaryRequest(
            global::ModernMT.AddGlossaryRequestType type,
            global::System.Collections.Generic.IList<global::ModernMT.AddGlossaryRequestTerm> terms,
            string? tuid)
        {
            this.Type = type;
            this.Tuid = tuid;
            this.Terms = terms ?? throw new global::System.ArgumentNullException(nameof(terms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGlossaryRequest" /> class.
        /// </summary>
        public AddGlossaryRequest()
        {
        }
    }
}