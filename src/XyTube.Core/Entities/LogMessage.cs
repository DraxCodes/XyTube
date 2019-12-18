namespace XyTube.Core.Entities
{
    public class LogMessage
    {
        public string Source { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Error { get; set; } = null;
    }
}
