using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange))]
    public partial interface ISetCustomLineItemShippingDetailsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CustomLineItemId { get; set; }

        IItemShippingDetails NextValue { get; set; }

        IItemShippingDetails PreviousValue { get; set; }
    }
}
