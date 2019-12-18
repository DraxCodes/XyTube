using System;
using XyTube.Core.Entities;
using XyTube.Core.Services;

namespace XyTube.UI.UiServices
{
    class Logger : ILogger
    {
        public void Log(LogMessage logMessage)
        {
            var error = logMessage.Error is null
                ? "Error: Null"
                : $"Error: {logMessage.Error}";

            Console.WriteLine($"[{logMessage.Source}] : {logMessage.Message} {error}");
        }
    }
}
