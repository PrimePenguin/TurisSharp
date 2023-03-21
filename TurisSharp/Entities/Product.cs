using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class TurisProducts
    {
        [JsonProperty("data")]
        public List<Product> Products { get; set; }
    }

    public class TurisProduct
    {
        [JsonProperty("data")]
        public Product Product { get; set; }
    }

    public class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brand_id")]
        public long? BrandId { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("ean")]
        public string Ean { get; set; }

        [JsonProperty("hs_code")]
        public string HsCode { get; set; }

        [JsonProperty("unit_cost")]
        public double? UnitCost { get; set; }

        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("inherit_prices_variant_id")]
        public string InheritPricesVariantId { get; set; }

        [JsonProperty("variant_entity_id")]
        public string VariantEntityId { get; set; }

        [JsonProperty("size_id")]
        public string SizeId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("sub_category_id")]
        public string SubCategoryId { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("dimensions")]
        public string Dimensions { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("case_volume")]
        public long CaseVolume { get; set; }

        [JsonProperty("stock")]
        public long Stock { get; set; }

        [JsonProperty("case_quantity")]
        public long CaseQuantity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_shown")]
        public bool IsShown { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("is_new")]
        public long IsNew { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("allow_backorders")]
        public bool AllowBackorders { get; set; }

        [JsonProperty("backorder_banner_date")]
        public DateTimeOffset? BackorderBannerDate { get; set; }

        [JsonProperty("warehouse_location")]
        public string WarehouseLocation { get; set; }

        [JsonProperty("wholesale_prices")]
        public List<Price> WholesalePrices { get; set; }

        [JsonProperty("retail_prices")]
        public List<Price> RetailPrices { get; set; }

        [JsonProperty("special_prices")]
        public List<SpecialPrice> SpecialPrices { get; set; }

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("is_shown")]
        public bool IsShown { get; set; }

        [JsonProperty("sort_order")]
        public long SortOrder { get; set; }
    }

    public class Price
    {
        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        [JsonProperty("price")]
        public long? UnitPrice { get; set; }
    }

    public class SpecialPrice
    {
        [JsonProperty("price_list_id")]
        public long PriceListId { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }
    }

    public class ProductPatch
    {
        [JsonProperty("stock")]
        public int Stock { get; set; }
    }
}

