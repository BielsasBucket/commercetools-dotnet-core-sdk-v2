using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLErrorLocation 
    {
        public int Line { get; set;}
        
        public int Column { get; set;}
    }
}
