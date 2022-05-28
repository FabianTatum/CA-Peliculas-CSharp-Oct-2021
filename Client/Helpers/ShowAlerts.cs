using System.Threading.Tasks;

namespace CrAgPeliculas.App.Client.Helpers
{
    public class ShowAlerts : IShowAlerts
    {
        public async Task ShowAlertMessage(string message)
        {
           await Task.FromResult(0);
        }
    }
}