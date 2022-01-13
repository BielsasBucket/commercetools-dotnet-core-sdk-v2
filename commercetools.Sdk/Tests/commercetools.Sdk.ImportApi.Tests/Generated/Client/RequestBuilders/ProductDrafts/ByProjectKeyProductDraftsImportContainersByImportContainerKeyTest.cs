using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.ProductDrafts
{
    public class ByProjectKeyProductDraftsImportContainersByImportContainerKeyTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .ProductDrafts()
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/product-drafts/import-containers/test_importContainerKey",
               }
       };
        }
    }
}
