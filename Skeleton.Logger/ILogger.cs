using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Logger
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogDebug(string message);
        void LogError(string message);
        void LogError(Exception ex);
        void LogError(string message, Exception ex);
        void LogFatal(string message);
        void LogFatal(Exception ex);
        string BuildExceptionMessage(Exception ex);
    }
}
