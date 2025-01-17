using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.LineItemImportDraft))]
    public partial interface ILineItemImportDraft
    {
        string ProductId { get; set; }

        ILocalizedString Name { get; set; }

        IProductVariantImportDraft Variant { get; set; }

        IPriceDraft Price { get; set; }

        long Quantity { get; set; }

        List<IItemState> State { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        ITaxRate TaxRate { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
