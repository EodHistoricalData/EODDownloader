using System.Threading.Tasks;

namespace EODLoader.Services.AutoUpdate
{
    public interface IAutoUpdateService
    {
        string CheckForUpdate();
        Task Start(string downloadUrl);
    }
}
