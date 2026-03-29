
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ModernMT
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ModernMT.JsonConverters.TranslateRequestPriorityJsonConverter),

            typeof(global::ModernMT.JsonConverters.TranslateRequestPriorityNullableJsonConverter),

            typeof(global::ModernMT.JsonConverters.TranslateRequestFormatJsonConverter),

            typeof(global::ModernMT.JsonConverters.TranslateRequestFormatNullableJsonConverter),

            typeof(global::ModernMT.JsonConverters.BatchTranslateRequestPriorityJsonConverter),

            typeof(global::ModernMT.JsonConverters.BatchTranslateRequestPriorityNullableJsonConverter),

            typeof(global::ModernMT.JsonConverters.DetectLanguageRequestFormatJsonConverter),

            typeof(global::ModernMT.JsonConverters.DetectLanguageRequestFormatNullableJsonConverter),

            typeof(global::ModernMT.JsonConverters.AddGlossaryRequestTypeJsonConverter),

            typeof(global::ModernMT.JsonConverters.AddGlossaryRequestTypeNullableJsonConverter),

            typeof(global::ModernMT.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.TranslateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.TranslateRequestPriority), TypeInfoPropertyName = "TranslateRequestPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.TranslateRequestFormat), TypeInfoPropertyName = "TranslateRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.TranslateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.TranslateResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.BatchTranslateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.BatchTranslateRequestPriority), TypeInfoPropertyName = "BatchTranslateRequestPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.BatchTranslateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.BatchTranslateResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.DetectLanguageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.DetectLanguageRequestFormat), TypeInfoPropertyName = "DetectLanguageRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.DetectLanguageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.DetectLanguageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.QualityEstimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.QualityEstimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.QualityEstimationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.LanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.Memory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.MemoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.MemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModernMT.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.CreateMemoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.UpdateMemoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.AddContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.ImportJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.ImportJobResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.AddGlossaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.AddGlossaryRequestType), TypeInfoPropertyName = "AddGlossaryRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModernMT.AddGlossaryRequestTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.AddGlossaryRequestTerm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.ContextVectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.ContextVectorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModernMT.ContextVectorResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModernMT.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModernMT.AddGlossaryRequestTerm>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}