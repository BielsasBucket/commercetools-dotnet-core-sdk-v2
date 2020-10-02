using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setDeliveryAddress")]
    public partial class StagedOrderSetDeliveryAddressAction : StagedOrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public Address Address { get; set;}
        public StagedOrderSetDeliveryAddressAction()
        { 
           this.Action = "setDeliveryAddress";
        }
    }
}
