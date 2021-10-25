using System.Threading.Tasks;

namespace CrAgPeliculas.App.Client.Services
{
    public interface IRepositories
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<T>> Get<T> (string url);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}