using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetShippingMethodChange : ISetShippingMethodChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShippingMethodChangeValue NextValue { get; set; }

        public IShippingMethodChangeValue PreviousValue { get; set; }
        public SetShippingMethodChange()
        {
            this.Type = "SetShippingMethodChange";
        }
    }
}
