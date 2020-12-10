using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryResourceIdentifier : IInventoryEntryResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public InventoryEntryResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("inventory-entry");
        }
    }
}
