using System;
using System.Collections.Generic;
using System.Text;

namespace Shlink.Client.Core.Models
{
    public class ShortUrlMeta
    {
        /// <summary>
        /// The date (in ISO-8601 format) from which this short code will be valid
        /// </summary>
        public string ValidSince { get; set; }

        /// <summary>
        /// The date (in ISO-8601 format) until which this short code will be valid
        /// </summary>
        public string ValidUntil { get; set; }

        /// <summary>
        /// The maximum number of allowed visits for this short code
        /// </summary>
        public int? MaxVisits { get; set; }
    }
}
