using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.ImportApi.Models;
using commercetools.ImportApi.Models.Common;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.Orders
{
    public class ByProjectKeyOrdersImportSinkKeyByImportSinkKeyTest : RequestBuilderParentTests
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
                   .Orders()
                   .ImportSinkKeyWithImportSinkKeyValue("test_importSinkKey")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/orders/importSinkKey=test_importSinkKey",
               }
       };
        }
    }
}