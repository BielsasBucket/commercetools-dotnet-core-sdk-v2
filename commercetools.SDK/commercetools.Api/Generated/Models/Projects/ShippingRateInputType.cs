using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [Discriminator(nameof(Type))]
    public abstract partial class ShippingRateInputType 
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public ShippingRateTierType TypeAsEnum => this.Type.GetEnum<ShippingRateTierType>();
    }
}