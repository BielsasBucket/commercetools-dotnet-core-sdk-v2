using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    public partial interface IProductDiscountSetKeyAction : IProductDiscountUpdateAction
    {
        string Key { get; set; }
    }
}
