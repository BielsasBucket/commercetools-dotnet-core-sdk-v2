using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetDefaultShippingAddressAction : ICustomerSetDefaultShippingAddressAction
    {
        public string Action { get; set;}
        
        public string AddressId { get; set;}
        
        public string AddressKey { get; set;}
        public CustomerSetDefaultShippingAddressAction()
        { 
           this.Action = "setDefaultShippingAddress";
        }
    }
}