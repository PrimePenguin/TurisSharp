using System;
using System.Net;
using Newtonsoft.Json;

namespace TurisSharp
{
    public class TurisException : Exception
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }

    public class Errors
    {
        [JsonProperty("status")]
        public string[] Status { get; set; }
    }
}
