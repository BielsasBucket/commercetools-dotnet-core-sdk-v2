using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("external")]
    public partial class ProductDiscountValueExternal : ProductDiscountValue
    {
        public ProductDiscountValueExternal()
        { 
           this.Type = "external";
        }
    }
}
