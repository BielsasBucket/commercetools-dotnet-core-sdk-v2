using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetAssetCustomFieldAction))]
    public partial interface IProductSetAssetCustomFieldAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
