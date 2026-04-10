#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// List supported languages
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.LanguagesResponse> ListLanguagesAsync(
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}