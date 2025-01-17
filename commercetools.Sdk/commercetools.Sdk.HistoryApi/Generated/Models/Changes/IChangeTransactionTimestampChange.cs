using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionTimestampChange))]
    public partial interface IChangeTransactionTimestampChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITransactionChangeValue Transaction { get; set; }

        string NextValue { get; set; }

        string PreviousValue { get; set; }
    }
}
