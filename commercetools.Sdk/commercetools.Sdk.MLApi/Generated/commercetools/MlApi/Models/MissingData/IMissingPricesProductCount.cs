using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesProductCount))]
    public partial interface IMissingPricesProductCount
    {
        long Total { get; set; }

        long MissingPrices { get; set; }
    }
}
