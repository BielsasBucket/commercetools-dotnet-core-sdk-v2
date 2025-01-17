using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelMeasurementsAction : IStagedOrderSetParcelMeasurementsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }
        public StagedOrderSetParcelMeasurementsAction()
        {
            this.Action = "setParcelMeasurements";
        }
    }
}
