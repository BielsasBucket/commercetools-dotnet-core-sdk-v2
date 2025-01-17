using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.PriceTier))]
    public partial interface IPriceTier
    {
        long MinimumQuantity { get; set; }

        ITypedMoney Value { get; set; }
    }
}
