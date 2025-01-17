using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAssetKeyChange))]
    public partial interface ISetAssetKeyChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssetChangeValue Asset { get; set; }

        string NextValue { get; set; }

        string PreviousValue { get; set; }
    }
}
