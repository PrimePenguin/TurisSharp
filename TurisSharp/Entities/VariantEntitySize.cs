using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class VariantEntitySize
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("variant_entity_id")]
        public long VariantEntityId { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("sort_order")]
        public object SortOrder { get; set; }

        [JsonProperty("cart_sort_order")]
        public object CartSortOrder { get; set; }
    }
}
