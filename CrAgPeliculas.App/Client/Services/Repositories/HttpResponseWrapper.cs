using System.Threading.Tasks;
using System.Net.Http;

namespace CrAgPeliculas.App.Client.Services
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(bool error, T response, HttpResponseMessage httpResponseMessage) 
        {
            this.Error = error;
            this.Response = response;
            this.HttpResponseMessage = httpResponseMessage;
               
        }

        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string> GetStringMsg()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}