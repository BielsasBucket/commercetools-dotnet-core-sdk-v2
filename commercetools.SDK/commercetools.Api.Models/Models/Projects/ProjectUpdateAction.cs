using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [Discriminator(nameof(Action))]
    public abstract partial class ProjectUpdateAction 
    {
        public string Action { get; set;}
    }
}
