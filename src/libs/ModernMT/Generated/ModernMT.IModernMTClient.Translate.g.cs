#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Translate text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.TranslateResponse> TranslateAsync(

            global::ModernMT.TranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate text
        /// </summary>
        /// <param name="source">
        /// Source language code (e.g., "en")
        /// </param>
        /// <param name="target">
        /// Target language code (e.g., "it")
        /// </param>
        /// <param name="q">
        /// Text to translate
        /// </param>
        /// <param name="hints">
        /// Comma-separated memory IDs for adaptive translation
        /// </param>
        /// <param name="priority">
        /// Translation priority
        /// </param>
        /// <param name="multiline">
        /// Whether to treat the text as multiline
        /// </param>
        /// <param name="format">
        /// Text format
        /// </param>
        /// <param name="altTranslations">
        /// Number of alternative translations to return
        /// </param>
        /// <param name="maskProfanities">
        /// Whether to mask profanities
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.TranslateResponse> TranslateAsync(
            string source,
            string target,
            string q,
            string? hints = default,
            global::ModernMT.TranslateRequestPriority? priority = default,
            bool? multiline = default,
            global::ModernMT.TranslateRequestFormat? format = default,
            int? altTranslations = default,
            bool? maskProfanities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}