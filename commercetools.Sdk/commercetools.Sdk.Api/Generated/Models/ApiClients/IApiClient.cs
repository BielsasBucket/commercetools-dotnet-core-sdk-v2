using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Api.Models.ApiClients.ApiClient))]
    public partial interface IApiClient
    {
        string Id { get; set; }

        string Name { get; set; }

        string Scope { get; set; }

        string Secret { get; set; }

        DateTime? LastUsedAt { get; set; }

        DateTime? DeleteAt { get; set; }

        DateTime? CreatedAt { get; set; }
    }
}
