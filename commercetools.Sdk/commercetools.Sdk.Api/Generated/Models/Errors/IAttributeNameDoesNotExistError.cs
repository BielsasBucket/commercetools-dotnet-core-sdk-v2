using commercetools.Api.Models.Errors;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AttributeNameDoesNotExistError))]
    public partial interface IAttributeNameDoesNotExistError : IErrorObject
    {
        string InvalidAttributeName { get; set;}
    }
}