using commercetools.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.InventoryEntryQuantitySetMessage))]
    public partial interface IInventoryEntryQuantitySetMessage : IMessage
    {
        long OldQuantityOnStock { get; set; }

        long NewQuantityOnStock { get; set; }

        long OldAvailableQuantity { get; set; }

        long NewAvailableQuantity { get; set; }

        IChannelReference SupplyChannel { get; set; }
    }
}
