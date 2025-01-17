using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddPaymentChange : IAddPaymentChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPaymentInfo NextValue { get; set; }

        public IPaymentInfo PreviousValue { get; set; }
        public AddPaymentChange()
        {
            this.Type = "AddPaymentChange";
        }
    }
}
