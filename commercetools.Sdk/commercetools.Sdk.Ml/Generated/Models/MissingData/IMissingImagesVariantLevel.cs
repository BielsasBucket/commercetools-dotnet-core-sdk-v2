using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImagesVariantLevel))]
    public partial interface IMissingImagesVariantLevel : IMissingImagesCount
    {
        new long MissingImages { get; set;}
        
        new long Total { get; set;}
    }
}