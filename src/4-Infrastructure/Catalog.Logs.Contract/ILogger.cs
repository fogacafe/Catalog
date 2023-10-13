namespace Catalog.Logs.Contract
{
    public interface ILogger
    {
        void Info(string message, params object[] args);
        void Warn(string message, params object[] args);
        void Error(Exception exception, string message, params object[] args);
        void Fatal(string message, params object[] args);
    }
}
