using System.Diagnostics;

namespace Blog.Web.Extensions
{
    public class BrowserConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new BrowserConsoleLogger();
        }

        public void Dispose()
        {
        }
    }

    public class BrowserConsoleLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Debug.WriteLine($"[{logLevel}] {formatter(state, exception)}");
        }
    }
}
