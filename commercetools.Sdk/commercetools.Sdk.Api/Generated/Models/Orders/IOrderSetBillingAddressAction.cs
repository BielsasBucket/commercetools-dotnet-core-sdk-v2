using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetBillingAddressAction))]
    public partial interface IOrderSetBillingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
