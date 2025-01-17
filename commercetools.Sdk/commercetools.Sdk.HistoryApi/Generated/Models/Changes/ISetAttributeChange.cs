using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAttributeChange))]
    public partial interface ISetAttributeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }
    }
}
