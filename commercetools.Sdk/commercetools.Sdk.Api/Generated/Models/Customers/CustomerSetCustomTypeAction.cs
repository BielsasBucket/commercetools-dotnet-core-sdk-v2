using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetCustomTypeAction : ICustomerSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CustomerSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
