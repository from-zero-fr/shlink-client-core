using Shlink.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shlink.Client.Core
{
    public interface IShlink
    {
        void Connect(Uri baseUrl, string apiKey);
        void Connect(string baseUrl, string apiKey);
        Task<ShortUrlItem> GetUrlAsync(string shortCode);
    }
}
