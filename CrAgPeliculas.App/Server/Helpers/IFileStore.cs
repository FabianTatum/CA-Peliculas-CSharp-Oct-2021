using System.Threading.Tasks;
namespace CrAgPeliculas.App.Server.Helpers
{
    public interface IFileStore
    {
        Task<string> SaveFile(byte[] content, string extension, string containerName);
        Task<string> EditFile(byte[] content, string extension, string containerName, string route);
        Task DeleteFile(string route, string containerName);
    }
}