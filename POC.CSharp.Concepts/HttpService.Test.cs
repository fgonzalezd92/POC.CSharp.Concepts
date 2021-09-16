using POC.Services.Classes;
using POC.Services.Interfaces;
using System;
using Xunit;

namespace POC.CSharp.Concepts
{
    public class HttpServiceTest
    {
        private readonly IHttpService _httpService;
        public HttpServiceTest(IHttpService httpService)
        {
            _httpService = httpService;
        }

        [Fact]
        public void GetRequestDataTest()
        {
           
            var result = _httpService.GetRequest<dynamic>("https://hub.dummyapis.com/employee", "noofRecords=10&idStarts=1001");

            Assert.NotNull(result);
        }

        [Fact]
        public void GetBadRequestDataTest()
        {

            var result = _httpService.GetRequest<dynamic>("https://hub.dummyapis.com/employee", "noofRecords=0&idStarts=1001");

            Assert.Null(result);
        }

        [Fact]
        public void PostRequestDataTest()
        {
            var data = new {
                title= "foo",
                body= "bar",
                userId= 1,
            };

            var result = _httpService.PostRequest<dynamic,dynamic>("https://jsonplaceholder.typicode.com/posts", data).Result;

            Assert.NotNull(result);
        }
    }
}
