using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace eDrsManagers.Interfaces
{
    public interface ILogsManager
    {
        JObject LogErrors(Exception ex);

    }
}
