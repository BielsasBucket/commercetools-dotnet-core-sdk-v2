using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [Discriminator(nameof(Name))]
    public abstract partial class AttributeType 
    {
        public string Name { get; set;}
    }
}
