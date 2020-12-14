using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetMetaKeywordsAction : IProductSetMetaKeywordsAction
    {
        public string Action { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public bool? Staged { get; set;}
        public ProductSetMetaKeywordsAction()
        { 
           this.Action = "setMetaKeywords";
        }
    }
}