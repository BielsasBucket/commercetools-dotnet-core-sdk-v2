using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changeAssetName")]
    public partial class ProductChangeAssetNameAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public LocalizedString Name { get; set;}
        public ProductChangeAssetNameAction()
        { 
           this.Action = "changeAssetName";
        }
    }
}
