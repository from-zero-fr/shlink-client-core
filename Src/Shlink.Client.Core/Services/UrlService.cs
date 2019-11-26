using Newtonsoft.Json;
using Shlink.Client.Core.Exceptions;
using Shlink.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shlink.Client.Core.Services
{
    public class UrlService : IDisposable
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="apiKey"></param>
        public UrlService(Uri baseUrl, string apiKey)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseUrl;
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortCode"></param>
        /// <returns></returns>
        public async Task<ShortUrlItem> GetAsync(string shortCode)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"/rest/v1/short-urls/{shortCode}"))
            {
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode == false)
                    {
                        throw new ApiException
                        {
                            StatusCode = (int)response.StatusCode,
                            Content = content
                        };
                    }
                    return JsonConvert.DeserializeObject<ShortUrlItem>(content);
                }
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}