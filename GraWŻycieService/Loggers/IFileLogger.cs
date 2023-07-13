namespace GraWŻycieService.Loggers
{
    
    public interface IFileLogger: ILogger
    {
        string FileName { get; }

    }
}