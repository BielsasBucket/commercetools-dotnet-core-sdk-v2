using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("store")]
    public partial class StoreReference : Reference
    {
        public Store Obj { get; set;}
        public StoreReference()
        { 
           this.TypeId = "store";
        }
    }
}
