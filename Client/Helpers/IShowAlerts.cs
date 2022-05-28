using System.Threading.Tasks;

namespace CrAgPeliculas.App.Client.Helpers
{
    public interface IShowAlerts
    {
        Task ShowAlertMessage(string message);
    }
}