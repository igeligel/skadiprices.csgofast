namespace skadiprices.csgofast.Constants
{
    /// <summary>
    /// Class which include all http header values used in
    /// the api.
    /// </summary>
    internal static class HttpHeaderValues
    {
        /// <summary>
        /// Accept Header value in HTTP requests.
        /// This will accept all stuff of contents. But the
        /// api is always returning json.
        /// </summary>
        internal const string AcceptAll = "*/*";

        /// <summary>
        /// Accept-Language Header value in HTTP requests.
        /// </summary>
        internal const string AcceptLanguage = "en-US;q=0.6,en;q=0.4,it;q=0.2";

        /// <summary>
        /// Origin Header value in HTTP requests.
        /// This needs to be given to hide real api requests.
        /// We are emulating the chrome extension 'Steam inventory helper' here.
        /// </summary>
        internal const string ChromeExtension = "chrome-extension://hddhnchjldeohpcnmagkajhjonnooneo";

        /// <summary>
        /// Accept-Encoding Header value in HTTP requests.
        /// </summary>
        internal const string GzipDeflateSdchBr = "gzip, deflate, sdch, br";

        /// <summary>
        /// If-None-Matched Header value in HTTP requests.
        /// </summary>
        internal const string IfNoneMatched =
            "W/\"48d5d-chU1klyIsYVi6Sb4TG6VwA\"";

        /// <summary>
        /// User-Agent Header value in HTTP requests.
        /// We are using the header set by chrome by default.
        /// </summary>
        internal const string UserAgent =
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
    }
}
