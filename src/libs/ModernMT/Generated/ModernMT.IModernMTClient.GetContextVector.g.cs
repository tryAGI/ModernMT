#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Generate context vector for adaptive translation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ContextVectorResponse> GetContextVectorAsync(

            global::ModernMT.ContextVectorRequest request,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate context vector for adaptive translation
        /// </summary>
        /// <param name="source"></param>
        /// <param name="targets"></param>
        /// <param name="text"></param>
        /// <param name="hints"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ContextVectorResponse> GetContextVectorAsync(
            string source,
            global::System.Collections.Generic.IList<string> targets,
            string text,
            string? hints = default,
            int? limit = default,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}