using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.PayloadNotIncluded))]
    public partial interface IPayloadNotIncluded
    {
        string Reason { get; set; }

        string PayloadType { get; set; }
    }
}
