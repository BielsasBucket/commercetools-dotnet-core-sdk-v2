using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderLineItemRemovedMessagePayload : IOrderLineItemRemovedMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public long RemovedQuantity { get; set; }

        public long NewQuantity { get; set; }

        public List<IItemState> NewState { get; set; }

        public ITypedMoney NewTotalPrice { get; set; }

        public ITaxedItemPrice NewTaxedPrice { get; set; }

        public IPrice NewPrice { get; set; }

        public IItemShippingDetails NewShippingDetail { get; set; }
        public OrderLineItemRemovedMessagePayload()
        {
            this.Type = "OrderLineItemRemoved";
        }
    }
}
