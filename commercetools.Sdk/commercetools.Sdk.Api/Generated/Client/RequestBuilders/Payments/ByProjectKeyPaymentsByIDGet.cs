using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.Payments
{
    public partial class ByProjectKeyPaymentsByIDGet : ApiMethod<ByProjectKeyPaymentsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyPaymentsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/payments/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyPaymentsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.Payments.IPayment> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Payments.IPayment>(requestMessage);
        }

    }
}
