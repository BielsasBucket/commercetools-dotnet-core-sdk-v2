using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.MLApi.Client.RequestBuilders.ImageSearch
{
    public partial class ByProjectKeyImageSearchConfigGet : ApiMethod<ByProjectKeyImageSearchConfigGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyImageSearchConfigGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/image-search/config";
        }




        public async Task<commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>(requestMessage);
        }

    }
}
