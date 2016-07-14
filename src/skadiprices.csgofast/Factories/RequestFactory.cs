using System;
using System.Net;
using System.Net.Http;

namespace skadiprices.csgofast.Factories
{
    internal class RequestFactory
    {
        internal static HttpResponseMessage Create()
        {
            HttpResponseMessage response;
            var handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.Deflate |
                                             DecompressionMethods.GZip;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("https://api.csgofast.com");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "If-None-Match", "W/\"48d5d-chU1klyIsYVi6Sb4TG6VwA\"");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept", "*/*");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept-Encoding", "gzip, deflate, sdch, br");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Accept-Language",
                    "de-DE,de;q=0.8,en-US;q=0.6,en;q=0.4,it;q=0.2");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36");
                client.DefaultRequestHeaders.TryAddWithoutValidation(
                    "Origin",
                    "chrome-extension://hddhnchjldeohpcnmagkajhjonnooneo");

                client.DefaultRequestHeaders.Host =
                    new Uri("https://api.csgofast.com").Host;
                response = client.GetAsync("/sih/all").Result;
            }
            return response;
        }
    }
}
