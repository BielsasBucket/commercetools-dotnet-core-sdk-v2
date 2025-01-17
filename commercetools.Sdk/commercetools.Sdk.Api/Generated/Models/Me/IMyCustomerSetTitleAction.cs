using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetTitleAction))]
    public partial interface IMyCustomerSetTitleAction : IMyCustomerUpdateAction
    {
        string Title { get; set; }
    }
}
