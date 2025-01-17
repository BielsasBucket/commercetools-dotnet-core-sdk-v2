using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        int Amount { get; set; }
    }
}
