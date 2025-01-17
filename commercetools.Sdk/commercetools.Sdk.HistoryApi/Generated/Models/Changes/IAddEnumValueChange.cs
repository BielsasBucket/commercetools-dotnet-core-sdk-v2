using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddEnumValueChange))]
    public partial interface IAddEnumValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string FieldName { get; set; }

        IEnumValue NextValue { get; set; }
    }
}
