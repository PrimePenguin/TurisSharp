using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class Buyer
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip_code")]
        public object ZipCode { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("phone_number")]
        public object PhoneNumber { get; set; }

        [JsonProperty("discount")]
        public object Discount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("logo_color")]
        public string LogoColor { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public object LastName { get; set; }

        [JsonProperty("buyer_no")]
        public object BuyerNo { get; set; }

        [JsonProperty("language_id")]
        public long LanguageId { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }
    }

    public partial class CustomFields
    {
        [JsonProperty("test_field_buyers")]
        public string TestFieldBuyers { get; set; }
    }
}

