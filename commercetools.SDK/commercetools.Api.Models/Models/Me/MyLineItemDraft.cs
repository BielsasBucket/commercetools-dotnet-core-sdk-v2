using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyLineItemDraft 
    {
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public double Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        
        public string Sku { get; set;}
    }
}
