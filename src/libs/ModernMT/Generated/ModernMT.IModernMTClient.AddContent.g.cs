#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Add content to a translation memory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ImportJobResponse> AddContentAsync(
            int id,

            global::ModernMT.AddContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add content to a translation memory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="sentence"></param>
        /// <param name="translation"></param>
        /// <param name="tuid"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ImportJobResponse> AddContentAsync(
            int id,
            string source,
            string target,
            string sentence,
            string translation,
            string? tuid = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}