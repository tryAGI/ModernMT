#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Estimate translation quality
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.QualityEstimationResponse> QualityEstimationAsync(

            global::ModernMT.QualityEstimationRequest request,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate translation quality
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="sentence"></param>
        /// <param name="translation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.QualityEstimationResponse> QualityEstimationAsync(
            string source,
            string target,
            string sentence,
            string translation,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}