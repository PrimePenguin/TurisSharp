using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class PriceList
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }
    }
}
