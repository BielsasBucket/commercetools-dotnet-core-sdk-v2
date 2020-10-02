using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class Attribute 
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
