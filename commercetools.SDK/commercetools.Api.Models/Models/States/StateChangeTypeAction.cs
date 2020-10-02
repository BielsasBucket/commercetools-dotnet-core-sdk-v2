using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("changeType")]
    public partial class StateChangeTypeAction : StateUpdateAction
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
        public StateChangeTypeAction()
        { 
           this.Action = "changeType";
        }
    }
}
