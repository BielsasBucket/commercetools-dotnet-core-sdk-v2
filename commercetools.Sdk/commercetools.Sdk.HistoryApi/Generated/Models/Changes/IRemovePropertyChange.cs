using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemovePropertyChange))]
    public partial interface IRemovePropertyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string Path { get; set; }

        Object PreviousValue { get; set; }
    }
}
