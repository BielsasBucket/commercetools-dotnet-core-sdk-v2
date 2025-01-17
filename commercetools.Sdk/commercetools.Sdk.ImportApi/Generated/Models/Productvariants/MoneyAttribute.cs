using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class MoneyAttribute : IMoneyAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ITypedMoney Value { get; set; }
        public MoneyAttribute()
        {
            this.Type = "money";
        }
    }
}
