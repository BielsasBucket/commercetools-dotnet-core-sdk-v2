using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    [SubTypeDiscriminator("external", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueExternal))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueRelative))]
    public partial interface IProductDiscountValue
    {
        string Type { get; set; }
    }
}
