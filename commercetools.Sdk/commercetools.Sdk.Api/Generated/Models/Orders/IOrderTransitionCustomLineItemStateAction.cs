using commercetools.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderTransitionCustomLineItemStateAction))]
    public partial interface IOrderTransitionCustomLineItemStateAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }

        IStateResourceIdentifier FromState { get; set; }

        IStateResourceIdentifier ToState { get; set; }

        DateTime? ActualTransitionDate { get; set; }
    }
}
