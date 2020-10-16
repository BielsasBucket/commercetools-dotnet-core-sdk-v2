using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.ProductProjections
{
   public class ByProjectKeyProductProjectionsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyProductProjectionsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyProductProjectionsKeyByKeyGet Get() {
           return new ByProjectKeyProductProjectionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}