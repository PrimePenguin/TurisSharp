using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class VariantEntity
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("variant_id")]
        public long VariantId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("colour_hex")]
        public object ColourHex { get; set; }

        [JsonProperty("media_id")]
        public object MediaId { get; set; }

        [JsonProperty("sort_order")]
        public object SortOrder { get; set; }

        [JsonProperty("is_media_synced_with_product")]
        public long IsMediaSyncedWithProduct { get; set; }
    }
}
