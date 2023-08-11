using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class TurisOrders
    {
        [JsonProperty("data")]
        public List<Order> Orders { get; set; }
    }

    public class TurisOrder
    {
        [JsonProperty("data")]
        public Order Order { get; set; }
    }

    public class Order
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("order_round")]
        public object OrderRound { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unique_id6")]
        public string UniqueId6 { get; set; }

        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("items_count")]
        public long ItemsCount { get; set; }

        [JsonProperty("cases_count")]
        public long? CasesCount { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("vat")]
        public long? Vat { get; set; }

        [JsonProperty("rec_equiv")]
        public long? RecEquiv { get; set; }

        [JsonProperty("show_rec_equiv")]
        public bool ShowRecEquiv { get; set; }

        [JsonProperty("shipping_total")]
        public long? ShippingTotal { get; set; }

        [JsonProperty("is_new")]
        public bool IsNew { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("voucher_percentage_discount")]
        public object VoucherPercentageDiscount { get; set; }

        [JsonProperty("voucher_monetary_discount")]
        public object VoucherMonetaryDiscount { get; set; }

        [JsonProperty("voucher")]
        public object Voucher { get; set; }

        [JsonProperty("currency")]
        public DataCurrency Currency { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("buyer_comment")]
        public string BuyerComment { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("purchase_order_no")]
        [CanBeNull]
        public string PurchaseOrderNo { get; set; }

        [JsonProperty("stripe_payment_link")]
        public string StripePaymentLink { get; set; }

        [JsonProperty("shipping_delivery_term_name")]
        public string ShippingDeliveryTermName { get; set; }

        [JsonProperty("shipping_delivery_term_id")]
        public object ShippingDeliveryTermId { get; set; }

        [JsonProperty("items")]
        public List<DataItem> Items { get; set; }

        [JsonProperty("creator_data")]
        public CreatorData CreatorData { get; set; }

        [JsonProperty("delivery")]
        public DataDelivery Delivery { get; set; }

        [JsonProperty("user")]
        public Admin User { get; set; }

        [JsonProperty("admin")]
        public Admin Admin { get; set; }

        [JsonProperty("agent")]
        public object Agent { get; set; }

        [JsonProperty("buyer_data")]
        public BuyerData BuyerData { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("attachments")]
        public List<object> Attachments { get; set; }

        [JsonProperty("disableButton")]
        public bool DisableButton { get; set; }

        [JsonProperty("admin_id")]
        public long? AdminId { get; set; }

        [JsonProperty("agent_id")]
        public object AgentId { get; set; }

        [JsonProperty("dropshipping_address")]
        public object DropshippingAddress { get; set; }

        [JsonProperty("dropshipping_currency")]
        public object DropshippingCurrency { get; set; }

        [JsonProperty("grand_total")]
        public long? GrandTotal { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
    }

    public class Admin
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("is_admin")]
        public long? IsAdmin { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("logo_color")]
        public string LogoColor { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("discount")]
        public long? Discount { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }

    public class Company
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reg_no")]
        public string RegNo { get; set; }

        [JsonProperty("company_slug")]
        public string CompanySlug { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("vat_type_id")]
        public long? VatTypeId { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("special_price_list_id")]
        public string SpecialPriceListId { get; set; }

        [JsonProperty("discount")]
        public long? Discount { get; set; }

        [JsonProperty("payment")]
        public string Payment { get; set; }

        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        [JsonProperty("allow_users")]
        public long? AllowUsers { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("logo_color")]
        public string LogoColor { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("customer_no")]
        public string CustomerNo { get; set; }

        [JsonProperty("is_customer_contractor")]
        public bool? IsCustomerContractor { get; set; }

        [JsonProperty("order_confirmation_email")]
        public string OrderConfirmationEmail { get; set; }

        [JsonProperty("shipping_delivery_terms_id")]
        public string ShippingDeliveryTermsId { get; set; }

        [JsonProperty("forwarder_name")]
        public string ForwarderName { get; set; }

        [JsonProperty("contract_no")]
        public int? ContractNo { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }

        [JsonProperty("recargo_de_equivalencia")]
        public string RecargoDeEquivalencia { get; set; }

        [JsonProperty("free_shipping_limit")]
        public int? FreeShippingLimit { get; set; }

        [JsonProperty("language_id")]
        public int? LanguageId { get; set; }

        [JsonProperty("is_test_account")]
        public bool? IsTestAccount { get; set; }

        [JsonProperty("minimum_order_amount")]
        public long? MinimumOrderAmount { get; set; }

        [JsonProperty("deliveries")]
        public List<DeliveryElement> Deliveries { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public CompanyCurrency Currency { get; set; }

        [JsonProperty("country_iso_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        [JsonProperty("country_iso_code_alpha3", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCodeAlpha3 { get; set; }

        [JsonProperty("dropshipping_list_id")]
        public object DropshippingListId { get; set; }

        [JsonProperty("fob_price_list_id")]
        public object FobPriceListId { get; set; }

        [JsonProperty("vat_exempted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VatExempted { get; set; }

        [JsonProperty("avatar_color", NullValueHandling = NullValueHandling.Include)]
        // [JsonConverter(typeof(ParseStringConverter))]
        public string AvatarColor { get; set; }

        [JsonProperty("express_ordering")]
        public object ExpressOrdering { get; set; }

        [JsonProperty("allow_sepa_payments", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllowSepaPayments { get; set; }

        [JsonProperty("read_only_delivery_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnlyDeliveryAddress { get; set; }

        [JsonProperty("delivery_term")]
        public object DeliveryTerm { get; set; }
    }

    public class CompanyCurrency
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("is_active")]
        public long? IsActive { get; set; }

        [JsonProperty("default")]
        public long? Default { get; set; }

        [JsonProperty("enabled")]
        public long? Enabled { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class DeliveryElement
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("is_address_primary")]
        public bool IsAddressPrimary { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("country_iso_code")]
        public string CountryIsoCode { get; set; }

        [JsonProperty("country_iso_code_alpha3")]
        public string CountryIsoCodeAlpha3 { get; set; }
    }

    public class BuyerData
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified_at")]
        public string EmailVerifiedAt { get; set; }

        [JsonProperty("is_admin")]
        public long? IsAdmin { get; set; }

        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("logo_color")]
        public string LogoColor { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("is_um")]
        public long? IsUm { get; set; }

        [JsonProperty("buyer_no")]
        public object BuyerNo { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }

        [JsonProperty("upload_unique_key")]
        public string UploadUniqueKey { get; set; }

        [JsonProperty("language_id")]
        public string LanguageId { get; set; }

        [JsonProperty("is_test_account")]
        public long? IsTestAccount { get; set; }

        [JsonProperty("session_parent_id")]
        public bool? SessionParentId { get; set; }

        [JsonProperty("stripe_id")]
        public string StripeId { get; set; }

        [JsonProperty("resend_set_password_email")]
        public bool ResendSetPasswordEmail { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }
    }

    public class CreatorData
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataCurrency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class DataDelivery
    {
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("country_iso_code")]
        public string CountryIsoCode { get; set; }

        [JsonProperty("country_iso_code_alpha3")]
        public string CountryIsoCodeAlpha3 { get; set; }
    }

    public class DataItem
    {
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("items")]
        public List<ItemItem> Items { get; set; }
    }

    public class ItemItem
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("line_no")]
        public long? LineNo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("cases")]
        public long? Cases { get; set; }

        [JsonProperty("case_quantity_preserved")]
        public long? CaseQuantityPreserved { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("final_discount")]
        public Discount FinalDiscount { get; set; }

        [JsonProperty("total_price")]
        public decimal? TotalPrice { get; set; }

        [JsonProperty("final_price")]
        public decimal? FinalPrice { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("desired_shipment_date")]
        public string DesiredShipmentDate { get; set; }

        [JsonProperty("shipment_date")]
        public string ShipmentDate { get; set; }

        [JsonProperty("do_not_ship_before")]
        public DateTime? DoNotShipBefore { get; set; }

        [JsonProperty("do_not_ship_after")]
        public string DoNotShipAfter { get; set; }

        [JsonProperty("order_rel_num")]
        public string OrderRelNum { get; set; }

        [JsonProperty("product")]
        public OrderProduct Product { get; set; }

        [JsonProperty("product_translations")]
        public List<object> ProductTranslations { get; set; }

        [JsonProperty("is_shipped")]
        public long? IsShipped { get; set; }

        [JsonProperty("amountOrders")]
        public object AmountOrders { get; set; }

        [JsonProperty("unitsOrdered")]
        public object UnitsOrdered { get; set; }

        [JsonProperty("specialTaxListRate")]
        public long? SpecialTaxListRate { get; set; }

        [JsonProperty("specialTaxSpainListRate")]
        public long? SpecialTaxSpainListRate { get; set; }
    }

    public class Discount
    {
        [JsonProperty("discount")]
        public long? DiscountDiscount { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class OrderProduct
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("ean")]
        // [JsonConverter(typeof(ParseStringConverter))]
        public long? Ean { get; set; }

        [JsonProperty("hs_code")]
        // [JsonConverter(typeof(ParseStringConverter))]
        public long? HsCode { get; set; }

        [JsonProperty("category_id")]
        public long? CategoryId { get; set; }

        [JsonProperty("sub_category_id")]
        public long? SubCategoryId { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("dimensions")]
        public string Dimensions { get; set; }

        [JsonProperty("weight")]
        public long? Weight { get; set; }

        [JsonProperty("weight_type_id")]
        public long? WeightTypeId { get; set; }

        [JsonProperty("case_volume")]
        public long? CaseVolume { get; set; }

        [JsonProperty("case_volume_type_id")]
        public long? CaseVolumeTypeId { get; set; }

        [JsonProperty("stock")]
        public long? Stock { get; set; }

        [JsonProperty("shopify_location_id")]
        public string ShopifyLocationId { get; set; }

        [JsonProperty("ignore_shopify_stock_sync")]
        public string IgnoreShopifyStockSync { get; set; }

        [JsonProperty("update_stock_via_erp")]
        public bool UpdateStockViaErp { get; set; }

        [JsonProperty("allow_backorders")]
        public bool AllowBackorders { get; set; }

        [JsonProperty("case_quantity")]
        public long? CaseQuantity { get; set; }

        [JsonProperty("case_quantity_method_id")]
        public long? CaseQuantityMethodId { get; set; }

        [JsonProperty("unit_of_measure_id")]
        public long? UnitOfMeasureId { get; set; }

        [JsonProperty("unit_cost")]
        public long? UnitCost { get; set; }

        [JsonProperty("sales_price")]
        public long? SalesPrice { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_shown")]
        public bool IsShown { get; set; }

        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        [JsonProperty("is_hidden")]
        public long? IsHidden { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("is_new")]
        public long? IsNew { get; set; }

        [JsonProperty("variant_id")]
        public long? VariantId { get; set; }

        [JsonProperty("variant_entity_id")]
        public long? VariantEntityId { get; set; }

        [JsonProperty("inherit_prices_variant_id")]
        public object InheritPricesVariantId { get; set; }

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("size_id")]
        public string SizeId { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("case_quantity_fob")]
        public object CaseQuantityFob { get; set; }

        [JsonProperty("volume_fob")]
        public object VolumeFob { get; set; }

        [JsonProperty("position")]
        public long? Position { get; set; }

        [JsonProperty("backorder_banner_date")]
        public DateTimeOffset? BackorderBannerDate { get; set; }

        [JsonProperty("warehouse_location")]
        public string WarehouseLocation { get; set; }

        [JsonProperty("case_quantity_dropshipping")]
        public int? CaseQuantityDropshipping { get; set; }

        [JsonProperty("is_dropshipping_free")]
        public bool IsDropshippingFree { get; set; }

        [JsonProperty("style_number")]
        public int? StyleNumber { get; set; }

        [JsonProperty("default_currency")]
        public DefaultCurrency DefaultCurrency { get; set; }

        [JsonProperty("special_tax_lists")]
        public List<object> SpecialTaxLists { get; set; }

        [JsonProperty("brand")]
        public object Brand { get; set; }

        [JsonProperty("product_translations")]
        public List<object> ProductTranslations { get; set; }
    }

    public class DefaultCurrency
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class Summary
    {
        [JsonProperty("items_total_price")]
        public decimal? ItemsTotalPrice { get; set; }

        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        [JsonProperty("discount_price")]
        public decimal? DiscountPrice { get; set; }

        [JsonProperty("shipping_price")]
        public decimal? ShippingPrice { get; set; }

        [JsonProperty("sub_total_price")]
        public decimal? SubTotalPrice { get; set; }

        [JsonProperty("vat_rate")]
        public long? VatRate { get; set; }

        [JsonProperty("vat_price")]
        public decimal? VatPrice { get; set; }

        [JsonProperty("rec_equiv_rate")]
        public long? RecEquivRate { get; set; }

        [JsonProperty("show_vat_percantage")]
        public long? ShowVatPercantage { get; set; }

        [JsonProperty("rec_equiv_price")]
        public long? RecEquivPrice { get; set; }

        [JsonProperty("sub_total_price_without_vat")]
        public decimal? SubTotalPriceWithoutVat { get; set; }

        [JsonProperty("grand_total_price")]
        public decimal? GrandTotalPrice { get; set; }

        [JsonProperty("fee_price")]
        public decimal? FeePrice { get; set; }
    }

    public class OrderUpdateRequest
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("status_id")]
        public long? StatusId { get; set; }

        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }
    }

    public class CreateOrderRequest
    {
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        [JsonProperty("products")]
        public List<OrderProduct> Products { get; set; }
    }

    public class UpdateOrderItemsRequest
    {
        [JsonProperty("items")]
        public List<UpdateOrderItem> UpdateOrderItems { get; set; }
    }

    public class UpdateOrderItem
    {
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("shipment_date")]
        public string ShipmentDate { get; set; }

        [JsonProperty("is_shipped")]
        public bool IsShipped { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("do_not_ship_after")]
        public string DoNotShipAfter { get; set; }

        [JsonProperty("desired_shipment_date")]
        public string DesiredShipmentDate { get; set; }
    }

    public enum StatusIdEnum
    {
        Pending = 1,
        AwaitingPayment = 2,
        AwaitingFulfillment = 3,
        AwaitingShipment = 4,
        AwaitingPickup = 5,
        PartiallyShipped = 6,
        Completed = 7,
        Shipped = 8,
        Cancelled = 9,
        Declined = 10,
        Refunded = 11,
        Disputed = 12,
        VerificationRequired = 13,
        PartiallyRefunded = 14,
    }
}





