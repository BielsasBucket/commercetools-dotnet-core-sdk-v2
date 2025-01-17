using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Money))]
    public partial interface IMoney
    {
        string CurrencyCode { get; set; }

        int CentAmount { get; set; }

        int FractionDigits { get; set; }

        IMoneyType Type { get; set; }
    }
}
