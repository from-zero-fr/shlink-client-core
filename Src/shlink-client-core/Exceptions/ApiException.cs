using System;
using System.Collections.Generic;
using System.Text;

namespace Shlink.Client.Core.Exceptions
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string Content { get; set; }
    }
}
