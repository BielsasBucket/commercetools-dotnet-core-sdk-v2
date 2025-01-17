using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.ProductTypeImport))]
    public partial interface IProductTypeImport : IImportResource
    {
        string Name { get; set; }

        string Description { get; set; }

        List<IAttributeDefinition> Attributes { get; set; }
    }
}
