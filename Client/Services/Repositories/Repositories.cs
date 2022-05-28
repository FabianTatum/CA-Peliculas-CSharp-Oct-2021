using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http;

namespace CrAgPeliculas.App.Client.Services
{
    public class Repositories : IRepositories
    {
        private readonly HttpClient httpClient;
        private JsonSerializerOptions defaultJSONoptions => new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public Repositories(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private async Task<T> DeserializerResponse<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(!responseHttp.IsSuccessStatusCode, null, responseHttp);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T,TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);

            if(responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializerResponse<TResponse>(responseHttp, defaultJSONoptions);
                return new HttpResponseWrapper<TResponse>(false, response, responseHttp);
            }
                return new HttpResponseWrapper<TResponse>(true, default, responseHttp);

        }

        public async Task<HttpResponseWrapper<T>> Get<T> (string url)
        {
            var responseHttp = await httpClient.GetAsync(url);

            if(responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializerResponse<T> (responseHttp, defaultJSONoptions);
                return new HttpResponseWrapper<T>(false, response, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<T>(true, default, responseHttp);
            }
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(!responseHttp.IsSuccessStatusCode, null, responseHttp);
        }
    }
}