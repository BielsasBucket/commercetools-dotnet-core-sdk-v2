using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductVariantChannelAvailability))]
    public partial interface IProductVariantChannelAvailability
    {
        bool? IsOnStock { get; set; }

        long? RestockableInDays { get; set; }

        long? AvailableQuantity { get; set; }
    }
}
