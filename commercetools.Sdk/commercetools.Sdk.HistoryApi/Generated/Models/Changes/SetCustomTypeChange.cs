using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomTypeChange : ISetCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields NextValue { get; set; }

        public ICustomFields PreviousValue { get; set; }
        public SetCustomTypeChange()
        {
            this.Type = "SetCustomTypeChange";
        }
    }
}
