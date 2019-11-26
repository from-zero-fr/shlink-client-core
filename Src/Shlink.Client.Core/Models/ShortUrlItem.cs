using System;
using System.Collections.Generic;
using System.Text;

namespace Shlink.Client.Core.Models
{
    public class ShortUrlItem
    {
        /// <summary>
        /// The short code for this short URL.
        /// </summary>
        public string ShortCode { get; set; }

        /// <summary>
        /// The short URL.
        /// </summary>
        public string ShortUrl { get; set; }

        /// <summary>
        /// The original long URL.
        /// </summary>
        public string LongUrl { get; set; }

        /// <summary>
        /// The date in which the short URL was created in ISO format.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The number of visits that this short URL has recieved.
        /// </summary>
        public long VisitsCount { get; set; }

        /// <summary>
        /// A list of tags applied to this short URL
        /// </summary>
        public string[] Tags { get; set; }

        public ShortUrlMeta Meta { get; set; }
    }
}
