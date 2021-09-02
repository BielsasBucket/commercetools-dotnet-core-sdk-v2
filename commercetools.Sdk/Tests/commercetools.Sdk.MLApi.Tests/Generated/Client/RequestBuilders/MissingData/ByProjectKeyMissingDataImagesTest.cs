using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.MLApi.Models;
using commercetools.MLApi.Models.Common;
using Xunit;

namespace commercetools.MLApi.Tests.Client.RequestBuilders.MissingData
{
    public class ByProjectKeyMissingDataImagesTest : RequestBuilderParentTests
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
                   .WithProjectKey("test_projectKey")
                   .MissingData()
                   .Images()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/missing-data/images",
               }
       };
        }
    }
}