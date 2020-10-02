using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListDraft 
    {
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<ShoppingListLineItemDraft> LineItems { get; set;}
        
        public List<TextLineItemDraft> TextLineItems { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public long DeleteDaysAfterLastModification { get; set;}
    }
}
