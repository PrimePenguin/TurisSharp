using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class TurisProductVariants
    {
        [JsonProperty("data")]
        public List<Variant> Variants { get; set; }
    }
    public class TurisProductVariant
    {
        [JsonProperty("data")]
        public Variant Variant { get; set; }
    }
    public class Variant
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_method")]
        public long DisplayMethod { get; set; }

        [JsonProperty("show_products_individually")]
        public long ShowProductsIndividually { get; set; }

        [JsonProperty("show_variant_options_as")]
        public string? ShowVariantOptionsAs { get; set; }

        [JsonProperty("default_entity_id")]
        public object? DefaultEntityId { get; set; }
    }
}
