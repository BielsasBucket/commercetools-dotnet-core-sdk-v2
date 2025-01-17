using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListAddLineItemAction))]
    public partial interface IMyShoppingListAddLineItemAction : IMyShoppingListUpdateAction
    {
        string Sku { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
