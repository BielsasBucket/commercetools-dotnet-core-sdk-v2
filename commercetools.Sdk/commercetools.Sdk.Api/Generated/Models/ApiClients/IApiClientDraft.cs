using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    [DeserializeAs(typeof(commercetools.Api.Models.ApiClients.ApiClientDraft))]
    public partial interface IApiClientDraft
    {
        string Name { get; set; }

        string Scope { get; set; }

        long? DeleteDaysAfterCreation { get; set; }
    }
}
