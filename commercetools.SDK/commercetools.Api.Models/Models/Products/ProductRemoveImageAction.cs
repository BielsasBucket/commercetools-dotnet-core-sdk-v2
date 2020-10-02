using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removeImage")]
    public partial class ProductRemoveImageAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string ImageUrl { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemoveImageAction()
        { 
           this.Action = "removeImage";
        }
    }
}
