using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("changeQuantity")]
    public partial class InventoryEntryChangeQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
        public InventoryEntryChangeQuantityAction()
        { 
           this.Action = "changeQuantity";
        }
    }
}
