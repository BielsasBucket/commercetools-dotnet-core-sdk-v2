using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("applyDeltaToCustomLineItemShippingDetailsTargets")]
    public partial class CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
        public CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction()
        { 
           this.Action = "applyDeltaToCustomLineItemShippingDetailsTargets";
        }
    }
}