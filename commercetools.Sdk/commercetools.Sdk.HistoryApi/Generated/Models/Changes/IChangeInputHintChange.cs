using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeInputHintChange))]
    public partial interface IChangeInputHintChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string FieldName { get; set; }

        string AttributeName { get; set; }

        ITextInputHint NextValue { get; set; }

        ITextInputHint PreviousValue { get; set; }
    }
}
