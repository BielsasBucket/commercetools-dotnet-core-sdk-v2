using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerChangePassword))]
    public partial interface ICustomerChangePassword
    {
        string Id { get; set; }

        long Version { get; set; }

        string CurrentPassword { get; set; }

        string NewPassword { get; set; }
    }
}
