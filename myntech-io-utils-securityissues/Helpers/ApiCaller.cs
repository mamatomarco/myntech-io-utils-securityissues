using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace myntech_io_utils_securityissues.Helpers
{
    public class ApiCaller
    {
        private static readonly HttpClient client = new HttpClient();

        public ApiCaller()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "Myntech IO Vulnerabilities Api Service");
        }

        public async Task<System.IO.Stream> PerformGetRequest(string url)
        {
            var data = client.GetStreamAsync(url);
            return await data;
        }
    }
}
