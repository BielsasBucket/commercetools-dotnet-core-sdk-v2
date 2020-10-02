using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderEditApplied")]
    public partial class OrderEditAppliedMessage : Message
    {
        public OrderEditReference Edit { get; set;}
        
        public OrderEditApplied Result { get; set;}
        public OrderEditAppliedMessage()
        { 
           this.Type = "OrderEditApplied";
        }
    }
}
