using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace POC.CSharp.Concepts
{
    public class MockHttpClientFactory : Mock<IHttpClientFactory>
    {
        public MockHttpClientFactory MockGetAsyncEspecificResponse()
        {
           // Setup(x => x.CreateClient()).Returns;

                return this;
        }
    }
}
