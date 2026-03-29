#nullable enable

namespace ModernMT
{
    public partial interface IModernMTClient
    {
        /// <summary>
        /// Add glossary terms to a memory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModernMT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ImportJobResponse> AddGlossaryAsync(
            int id,

            global::ModernMT.AddGlossaryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add glossary terms to a memory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="tuid"></param>
        /// <param name="terms"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModernMT.ImportJobResponse> AddGlossaryAsync(
            int id,
            global::ModernMT.AddGlossaryRequestType type,
            global::System.Collections.Generic.IList<global::ModernMT.AddGlossaryRequestTerm> terms,
            string? tuid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}