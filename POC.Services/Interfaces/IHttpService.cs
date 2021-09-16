using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Services.Interfaces
{
    public interface IHttpService
    {
        public T GetRequest<T>(string endPoint, string parameters);
        public Task<T> PostRequest<T, P>(string endPoint, P data);
    }
}
