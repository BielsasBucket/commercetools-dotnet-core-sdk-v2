using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderReference))]
    public partial interface IOrderReference : IReference
    {
        IOrder Obj { get; set; }
    }
}
