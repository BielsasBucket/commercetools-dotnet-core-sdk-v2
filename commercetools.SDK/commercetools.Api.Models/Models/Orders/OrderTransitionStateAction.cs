using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("transitionState")]
    public partial class OrderTransitionStateAction : OrderUpdateAction
    {
        public StateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
        public OrderTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
