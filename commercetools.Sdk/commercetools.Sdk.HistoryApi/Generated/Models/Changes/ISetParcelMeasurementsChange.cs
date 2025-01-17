using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetParcelMeasurementsChange))]
    public partial interface ISetParcelMeasurementsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IParcelChangeValue Parcel { get; set; }

        IParcelMeasurements NextValue { get; set; }

        IParcelMeasurements PreviousValue { get; set; }
    }
}
