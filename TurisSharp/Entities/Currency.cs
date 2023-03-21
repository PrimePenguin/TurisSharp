using Newtonsoft.Json;
using System.Collections.Generic;

namespace TurisSharp.Entities
{
    public class Currencies
    {
        [JsonProperty("data")]
        public List<Currency> Currency { get; set; }
    }
    public class Currency
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
