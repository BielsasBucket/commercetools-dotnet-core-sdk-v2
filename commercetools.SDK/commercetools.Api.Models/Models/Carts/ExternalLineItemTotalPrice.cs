using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ExternalLineItemTotalPrice 
    {
        public Money Price { get; set;}
        
        public Money TotalPrice { get; set;}
    }
}
