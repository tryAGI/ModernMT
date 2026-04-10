#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Get a translation memory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.MemoryResponse> GetMemoryAsync(
            int id,
            global::ModernMT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}