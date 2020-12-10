using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public abstract partial class ReturnItem : IReturnItem
    {
        public string Id { get; set;}
        
        public long Quantity { get; set;}
        
        public string Type { get; set;}
        
        public string Comment { get; set;}
        
        public IReturnShipmentState ShipmentState { get; set;}
        
        public IReturnPaymentState PaymentState { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public DateTime CreatedAt { get; set;}
    }
}
