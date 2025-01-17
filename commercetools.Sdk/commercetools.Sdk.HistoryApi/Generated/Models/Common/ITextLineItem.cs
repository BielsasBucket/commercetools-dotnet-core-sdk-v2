using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.TextLineItem))]
    public partial interface ITextLineItem
    {
        string AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        ILocalizedString Description { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        int Quantity { get; set; }
    }
}
