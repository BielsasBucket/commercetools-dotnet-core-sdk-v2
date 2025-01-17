using commercetools.Api.Models.Stores;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerRemoveStoreAction : ICustomerRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CustomerRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}
