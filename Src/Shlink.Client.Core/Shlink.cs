using Shlink.Client.Core.Models;
using Shlink.Client.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shlink.Client.Core
{
    public class Shlink : IShlink
    {
        private string _apiKey;
        private Uri _baseUrl;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        public void Connect(Uri baseUrl, string apiKey)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        public void Connect(string baseUrl, string apiKey)
        {
            _apiKey = apiKey;
            _baseUrl = new Uri(baseUrl);
        }

        public async Task<ShortUrlItem> GetUrlAsync(string shortCode)
        {
            using (UrlService svc = new UrlService(_baseUrl, _apiKey))
            {
                return await svc.GetAsync(shortCode);
            }
        }

    }
}
