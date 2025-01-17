using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    public partial interface ICartRemoveDiscountCodeAction : ICartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
