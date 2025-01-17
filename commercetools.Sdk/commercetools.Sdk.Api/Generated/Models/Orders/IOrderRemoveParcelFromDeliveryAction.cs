using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderRemoveParcelFromDeliveryAction))]
    public partial interface IOrderRemoveParcelFromDeliveryAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }
    }
}
