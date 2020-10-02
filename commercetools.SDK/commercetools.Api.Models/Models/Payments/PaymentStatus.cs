using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentStatus 
    {
        public string InterfaceCode { get; set;}
        
        public string InterfaceText { get; set;}
        
        public StateReference State { get; set;}
    }
}
