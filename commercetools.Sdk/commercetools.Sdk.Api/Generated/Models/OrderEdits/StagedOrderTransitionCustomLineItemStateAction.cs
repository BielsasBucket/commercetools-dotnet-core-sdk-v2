using commercetools.Api.Models.States;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderTransitionCustomLineItemStateAction : IStagedOrderTransitionCustomLineItemStateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public long Quantity { get; set; }

        public IStateResourceIdentifier FromState { get; set; }

        public IStateResourceIdentifier ToState { get; set; }

        public DateTime? ActualTransitionDate { get; set; }
        public StagedOrderTransitionCustomLineItemStateAction()
        {
            this.Action = "transitionCustomLineItemState";
        }
    }
}
