using skadiprices.csgofast.Constants;
using System;
using System.Net;
using System.Net.Http;

namespace skadiprices.csgofast.Factories
{
    /// <summary>
    /// Request factory which is used to create HTTP Requests.
    /// This class should provide an easy access to do HTTP Requests
    /// regarding the csgofast.com pricing api.
    /// </summary>
    internal class RequestFactory
    {
        /// <summary>
        /// Method to create a HTTP Request. This takes no parameters
        /// because there is just one request done to the api.
        /// </summary>
        /// <returns>
        /// The response of the request as HttpResponseMessage.
        /// </returns>
        internal static HttpResponseMessage Create()
        {
            HttpResponseMessage response;
            var handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.Deflate |
                                             DecompressionMethods.GZip;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = Uris.CsGoFastSecured;
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.IfNoneMatch, HttpHeaderValues.IfNoneMatched);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Accept, HttpHeaderValues.AcceptAll);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptEncoding,
                    HttpHeaderValues.GzipDeflateSdchBr);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.AcceptLanguage,
                    HttpHeaderValues.AcceptLanguage);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.UserAgent, HttpHeaderValues.UserAgent);
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    HttpHeaderKeys.Origin, HttpHeaderValues.ChromeExtension);

                client.DefaultRequestHeaders.Host = Uris.CsGoFastSecured.Host;
                response = client.GetAsync(CsGoFastPaths.AllPrices).Result;
            }
            return response;
        }
    }
}
