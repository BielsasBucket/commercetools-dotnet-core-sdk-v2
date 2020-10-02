using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class QueryPrice 
    {
        public string Id { get; set;}
        
        public Money Value { get; set;}
        
        public string Country { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public ChannelReference Channel { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        
        public DiscountedPrice Discounted { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public List<PriceTierDraft> Tiers { get; set;}
    }
}
