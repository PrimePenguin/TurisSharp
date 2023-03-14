using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class TurisProductGroups
    {
        [JsonProperty("data")]
        public List<ProductGroup> ProductGroups { get; set; }
    }

    public class TurisProductGroup
    {
        [JsonProperty("data")]
        public ProductGroup ProductGroup { get; set; }
    }

    public class ProductGroup
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sort_order")]
        public long SortOrder { get; set; }

        [JsonProperty("is_visible")]
        public bool IsVisible { get; set; }

        [JsonProperty("resource_name")]
        public string ResourceName { get; set; }

        [JsonProperty("nested")]
        public List<object> Nested { get; set; }

        [JsonProperty("link_url")]
        public object LinkUrl { get; set; }

        [JsonProperty("frontend_key")]
        public string FrontendKey { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }
    }
}
