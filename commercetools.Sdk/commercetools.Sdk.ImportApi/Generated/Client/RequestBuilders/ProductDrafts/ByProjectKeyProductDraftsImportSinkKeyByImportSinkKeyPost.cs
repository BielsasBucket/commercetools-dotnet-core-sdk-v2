using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ProductDrafts
{
    public partial class ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.ImportApi.Models.Importrequests.IProductDraftImportRequest ProductDraftImportRequest;

        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.ImportApi.Models.Importrequests.IProductDraftImportRequest productDraftImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.ProductDraftImportRequest = productDraftImportRequest;
            this.RequestUrl = $"/{ProjectKey}/product-drafts/importSinkKey={ImportSinkKey}";
        }




        public async Task<commercetools.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importrequests.IImportResponse>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProductDraftImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
