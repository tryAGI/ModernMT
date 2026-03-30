
#nullable enable

namespace ModernMT
{
    public sealed partial class ModernMTClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::ModernMT.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "MMT-ApiKey",
                Value = apiKey,
            });
        }
    }
}