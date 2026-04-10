#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Create a translation memory
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.MemoryResponse> CreateMemoryAsync(

            global::ModernMT.CreateMemoryRequest request,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a translation memory
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="externalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.MemoryResponse> CreateMemoryAsync(
            string name,
            string? description = default,
            string? externalId = default,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}