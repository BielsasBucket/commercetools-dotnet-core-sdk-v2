namespace commercetools.Api.Models.Projects
{
    public partial class SearchIndexingConfiguration : ISearchIndexingConfiguration
    {
        public ISearchIndexingConfigurationValues Products { get; set; }

        public ISearchIndexingConfigurationValues Orders { get; set; }
    }
}
