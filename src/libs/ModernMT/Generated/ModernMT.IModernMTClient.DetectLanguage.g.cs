#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.DetectLanguageResponse> DetectLanguageAsync(

            global::ModernMT.DetectLanguageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect language of text
        /// </summary>
        /// <param name="q">
        /// Text to detect language of
        /// </param>
        /// <param name="format"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.DetectLanguageResponse> DetectLanguageAsync(
            string q,
            global::ModernMT.DetectLanguageRequestFormat? format = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}