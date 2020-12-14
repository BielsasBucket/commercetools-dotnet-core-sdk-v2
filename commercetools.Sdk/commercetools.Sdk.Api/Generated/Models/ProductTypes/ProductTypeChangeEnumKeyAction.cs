using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeEnumKeyAction : IProductTypeChangeEnumKeyAction
    {
        public string Action { get; set;}
        
        public string AttributeName { get; set;}
        
        public string Key { get; set;}
        
        public string NewKey { get; set;}
        public ProductTypeChangeEnumKeyAction()
        { 
           this.Action = "changeEnumKey";
        }
    }
}