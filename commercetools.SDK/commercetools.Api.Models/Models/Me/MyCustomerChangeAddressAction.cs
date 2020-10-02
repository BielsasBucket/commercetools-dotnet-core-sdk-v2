using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeAddress")]
    public partial class MyCustomerChangeAddressAction : MyCustomerUpdateAction
    {
        public string AddressId { get; set;}
        
        public Address Address { get; set;}
        public MyCustomerChangeAddressAction()
        { 
           this.Action = "changeAddress";
        }
    }
}
