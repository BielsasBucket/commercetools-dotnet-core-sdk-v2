using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setProductVariantKey")]
    public partial class ProductSetProductVariantKeyAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetProductVariantKeyAction()
        { 
           this.Action = "setProductVariantKey";
        }
    }
}
