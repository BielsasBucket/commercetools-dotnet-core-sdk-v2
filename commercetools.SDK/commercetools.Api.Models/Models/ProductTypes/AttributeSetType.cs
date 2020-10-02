using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("set")]
    public partial class AttributeSetType : AttributeType
    {
        public AttributeType ElementType { get; set;}
        public AttributeSetType()
        { 
           this.Name = "set";
        }
    }
}
