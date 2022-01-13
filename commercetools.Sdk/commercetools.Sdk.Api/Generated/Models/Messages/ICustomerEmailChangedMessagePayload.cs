using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerEmailChangedMessagePayload))]
    public partial interface ICustomerEmailChangedMessagePayload : IMessagePayload
    {
        string Email { get; set; }
    }
}
