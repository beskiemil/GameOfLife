namespace GraWŻycieService.Loggers
{
    public interface IConsoleLogger
    {
        IFileLogger FileLogger { get; }

        void LogMessage(string message);
    }
}