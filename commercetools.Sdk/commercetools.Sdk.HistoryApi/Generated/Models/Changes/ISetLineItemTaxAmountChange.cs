using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTaxAmountChange))]
    public partial interface ISetLineItemTaxAmountChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

        ITaxMode TaxMode { get; set; }

        ITaxRate NextValue { get; set; }

        ITaxRate PreviousValue { get; set; }
    }
}
