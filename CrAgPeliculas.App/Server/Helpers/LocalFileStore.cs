using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;
using System;

namespace CrAgPeliculas.App.Server.Helpers
{
    public class LocalFileStore : IFileStore
    {

        private readonly IWebHostEnvironment env;
        private readonly IHttpContextAccessor httpContextAccessor;

        public LocalFileStore(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            this.env = env;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SaveFile(byte[] content, string extension, string containerName)
        {
            var filename = $"{Guid.NewGuid()}{extension}";
            string folder = Path.Combine(env.WebRootPath, containerName);

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string saveRoute = Path.Combine(folder, filename);
            await File.WriteAllBytesAsync(saveRoute, content);

            var currentUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var databaseRoute = Path.Combine(currentUrl, folder, filename);
            return databaseRoute; 
        }

        public async Task<string> EditFile(byte[] content, string extension, string containerName, string route)
        {
            if(String.IsNullOrEmpty(route))
            {
                await DeleteFile(route, containerName);
            }

            return await SaveFile(content, extension, containerName);
        }

        public Task DeleteFile(string route, string containerName)
        {
            var filename = Path.GetFileName(route);
            string directoryFile = Path.Combine(env.WebRootPath, containerName, filename);

            if(File.Exists(directoryFile))
            {
                File.Delete(directoryFile);
            }
            return Task.FromResult(0);
        }

    }
}