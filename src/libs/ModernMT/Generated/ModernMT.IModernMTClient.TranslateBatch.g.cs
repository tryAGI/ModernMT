#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Submit batch translation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.BatchTranslateResponse> TranslateBatchAsync(

            global::ModernMT.BatchTranslateRequest request,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit batch translation
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="q"></param>
        /// <param name="webhook">
        /// Webhook URL for batch completion callback
        /// </param>
        /// <param name="metadata">
        /// Optional metadata passed through to webhook
        /// </param>
        /// <param name="hints"></param>
        /// <param name="priority"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.BatchTranslateResponse> TranslateBatchAsync(
            string source,
            string target,
            global::System.Collections.Generic.IList<string> q,
            string webhook,
            object? metadata = default,
            string? hints = default,
            global::ModernMT.BatchTranslateRequestPriority? priority = default,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}