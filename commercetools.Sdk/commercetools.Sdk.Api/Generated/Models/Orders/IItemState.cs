using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ItemState))]
    public partial interface IItemState
    {
        double Quantity { get; set; }

        IStateReference State { get; set; }
    }
}
