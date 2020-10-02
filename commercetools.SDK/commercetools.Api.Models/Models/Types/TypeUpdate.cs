using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class TypeUpdate 
    {
        public long Version { get; set;}
        
        public List<TypeUpdateAction> Actions { get; set;}
    }
}
