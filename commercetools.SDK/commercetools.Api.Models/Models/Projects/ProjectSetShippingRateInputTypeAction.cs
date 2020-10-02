using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("setShippingRateInputType")]
    public partial class ProjectSetShippingRateInputTypeAction : ProjectUpdateAction
    {
        public ShippingRateInputType ShippingRateInputType { get; set;}
        public ProjectSetShippingRateInputTypeAction()
        { 
           this.Action = "setShippingRateInputType";
        }
    }
}
