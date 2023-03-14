using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class Brand
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("media_id")]
        public object MediaId { get; set; }

        [JsonProperty("is_shown")]
        public bool IsShown { get; set; }

        [JsonProperty("sort_order")]
        public object SortOrder { get; set; }
    }
}
