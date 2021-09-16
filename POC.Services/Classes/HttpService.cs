using Newtonsoft.Json;
using POC.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace POC.Services.Classes
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        public HttpService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }
        
        public T GetRequest<T>(string endPoint, string parameters)
        {
            var response = _httpClient.GetAsync($"{endPoint}?{parameters}").Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultString = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<T>(resultString);
                return result;
            }
            else
            {
                return default;
            }
        }

        public async Task<T> PostRequest<T, P>(string endPoint, P data)
        {
            var httpContent = JsonContent.Create<P>(data);

            var response = await _httpClient.PostAsync($"{endPoint}", httpContent);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resultString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(resultString);
                return result;
            }
            else
            {
                return default;
            }
        }
    }
}
