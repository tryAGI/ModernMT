
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "MMT-ApiKey")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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