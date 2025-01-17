using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Labels
{
    public partial class ProductLabel : IProductLabel
    {
        public string Type { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductLabel()
        {
            this.Type = "ProductLabel";
        }
    }
}
