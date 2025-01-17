using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.BooleanSetAttribute))]
    public partial interface IBooleanSetAttribute : IAttribute
    {
        List<bool> Value { get; set; }
    }
}
