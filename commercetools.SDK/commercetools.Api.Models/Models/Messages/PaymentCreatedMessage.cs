using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentCreated")]
    public partial class PaymentCreatedMessage : Message
    {
        public Payment Payment { get; set;}
        public PaymentCreatedMessage()
        { 
           this.Type = "PaymentCreated";
        }
    }
}
