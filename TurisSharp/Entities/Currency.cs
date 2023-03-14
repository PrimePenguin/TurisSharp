using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class Currency
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("is_active")]
        public long IsActive { get; set; }

        [JsonProperty("default")]
        public long Default { get; set; }

        [JsonProperty("enabled")]
        public long Enabled { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
