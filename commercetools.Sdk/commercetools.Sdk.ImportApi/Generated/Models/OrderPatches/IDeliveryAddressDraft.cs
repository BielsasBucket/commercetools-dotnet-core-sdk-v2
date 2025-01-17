using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.DeliveryAddressDraft))]
    public partial interface IDeliveryAddressDraft
    {
        string DeliveryId { get; set; }

        IAddress Address { get; set; }
    }
}
