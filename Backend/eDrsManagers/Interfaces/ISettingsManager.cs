using eDrsDB.Models;

namespace eDrsManagers.Interfaces
{
    public interface ISettingsManager
    {
        bool ChangeCredentials(LrCredential model);
        LrCredential GetCredentials();
    }
}