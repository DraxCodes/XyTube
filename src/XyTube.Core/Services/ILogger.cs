using XyTube.Core.Entities;

namespace XyTube.Core.Services
{
    public interface ILogger
    {
        public void Log(LogMessage logMessage);
    }
}
