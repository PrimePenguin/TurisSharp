using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_slug")]
        public string CategorySlug { get; set; }

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("is_visible")]
        public bool IsVisible { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("nested")]
        public List<object> Nested { get; set; }
    }
}
