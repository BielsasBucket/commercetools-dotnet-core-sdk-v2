using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductPriceExternalDiscountSet")]
    public partial class ProductPriceExternalDiscountSetMessagePayload : MessagePayload
    {
        public int VariantId { get; set;}
        
        public string VariantKey { get; set;}
        
        public string Sku { get; set;}
        
        public string PriceId { get; set;}
        
        public DiscountedPrice Discounted { get; set;}
        
        public bool Staged { get; set;}
        public ProductPriceExternalDiscountSetMessagePayload()
        { 
           this.Type = "ProductPriceExternalDiscountSet";
        }
    }
}
