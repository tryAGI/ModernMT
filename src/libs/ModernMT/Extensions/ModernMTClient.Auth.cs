#nullable enable

namespace ModernMT;

public partial class ModernMTClient
{
    /// <summary>
    /// After Bearer auth is set on the request, convert to MMT-ApiKey header.
    /// ModernMT uses MMT-ApiKey header instead of Authorization: Bearer.
    /// </summary>
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("MMT-ApiKey", apiKey);
        }
    }
}
